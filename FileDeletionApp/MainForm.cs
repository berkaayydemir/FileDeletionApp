using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDeletionApp
{
    public partial class MainForm : Form
    {
        private DateTime targetDateTime;
        private string filePath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private async void btnSchedule_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            MessageBox.Show("Silme işlemi planlandı. Program belirttiğiniz tarihe kadar çalışmaya devam edecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await WaitAndDeleteFile();
        }

        private async Task WaitAndDeleteFile()
        {
            try
            {
                while (DateTime.Now < targetDateTime)
                {
                    await Task.Delay(1000);
                }

                DeleteFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    MessageBox.Show("Dosya başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dosya bulunamadı. Silme işlemi iptal edildi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Dosya üzerinde yeterli izin yok. Lütfen dosya izinlerini kontrol edin.", "Erişim Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"Dosya şu anda başka bir uygulama tarafından kullanılıyor: {ioEx.Message}", "G/Ç Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            DateTime selectedDateTime = dtpDateTime.Value;

            targetDateTime = new DateTime(
                selectedDateTime.Year,
                selectedDateTime.Month,
                selectedDateTime.Day,
                selectedDateTime.Hour,
                selectedDateTime.Minute,
                0
            );

            if (targetDateTime <= DateTime.Now)
            {
                MessageBox.Show("Gelecekte bir tarih ve saat girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            filePath = txtFilePath.Text;
            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Lütfen geçerli bir dosya yolu girin veya bir dosya seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Belirtilen dosya bulunamadı. Lütfen doğru bir dosya yolu girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}