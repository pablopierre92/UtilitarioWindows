using System;
using System.Diagnostics;
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
            string comando = "Del /S /F /Q %temp%";

            // Configura as propriedades do processo
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c " + comando;
            psi.UseShellExecute = true; // Usa o shell para iniciar o processo
            psi.Verb = "runas"; // Executa como administrador
                       
            Process.Start(psi);

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

        private void btn_Corrige_Click(object sender, EventArgs e)
        {
            string comando = "sfc /scannow";

            // Configura as propriedades do processo
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c " + comando;
            psi.UseShellExecute = true; // Usa o shell para iniciar o processo
            psi.Verb = "runas"; // Executa como administrador

            MessageBox.Show("Será feita a procura de erros no sistema e correção");
            // Inicia o processo
            Process.Start(psi);


        }

        private void btn_chkdsk_Click(object sender, EventArgs e)
        {
            string comando = "chkdsk /r /f";

            // Configura as propriedades do processo
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c " + comando;
            psi.UseShellExecute = true; // Usa o shell para iniciar o processo
            psi.Verb = "runas"; // Executa como administrador

            MessageBox.Show("Quando começar digite Y para ser feita a verificação de disco quando reiniciar");
            // Inicia o processo
            Process.Start(psi);
        }

        

    }

}
