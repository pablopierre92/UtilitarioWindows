using System;
using System.IO;

namespace PPN
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void btn_Temp_Click(object sender, EventArgs e)
        {
            string tempPath = Path.GetTempPath();
            CleanDirectory(tempPath);

            // Pasta %Temp%
            string userTempPath = Environment.GetEnvironmentVariable("TEMP");
            CleanDirectory(userTempPath);

            // Pasta Prefetch
            string prefetchPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Prefetch");
            CleanDirectory(prefetchPath);

            // Pasta Recent
            string recentPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Recent));
            CleanDirectory(recentPath);

            MessageBox.Show("Limpeza concluída!");
        }

        private void CleanDirectory(string directoryPath)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch (IOException)
                    {
                        // Se não for possível excluir o arquivo, continue para o próximo
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao limpar a pasta {directoryPath}: {ex.Message}");
            }

        }
    }

        
    
}
