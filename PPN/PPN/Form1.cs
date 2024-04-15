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


            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c " + comando;
            psi.UseShellExecute = true;
            psi.Verb = "runas";

            MessageBox.Show("Será feita a procura de erros no sistema e correção");

            Process.Start(psi);


        }

        private void btn_chkdsk_Click(object sender, EventArgs e)
        {
            string comando = "chkdsk /r /f";


            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c " + comando;
            psi.UseShellExecute = true;
            psi.Verb = "runas";

            MessageBox.Show("Quando começar digite Y para ser feita a verificação de disco quando reiniciar");

            Process.Start(psi);
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            try
            {
                // Caminho da pasta a ser criada
                string caminhoPasta = @"C:\BackupDrivers";

                // Verifica se a pasta não existe
                if (!Directory.Exists(caminhoPasta))
                {
                    // Cria a pasta
                    Directory.CreateDirectory(caminhoPasta);
                    MessageBox.Show("Pasta BackupDrivers em C: criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A pasta BackupDrivers em C: já existe!, os arquivos serão copiados para ela", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                string comando = "dism /online /export-driver /destination:C:\\BackupDrivers";


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = "/c " + comando;
                psi.UseShellExecute = true;
                psi.Verb = "runas";


                Process.Start(psi);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar a pasta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_importar_Click(object sender, EventArgs e)
        {
            
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                
                folderBrowserDialog.Description = "Selecione o diretório desejado";

                
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtem o caminho do diretorio selecionado
                    string caminhoSelecionado = folderBrowserDialog.SelectedPath;
                    
                    MessageBox.Show("O diretório selecionado é: " + caminhoSelecionado, "Diretório Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                string comando = "Dism /online /Add-Driver /Driver:E:{caminhoSelecionado} /Recurse";


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = "/c " + comando;
                psi.UseShellExecute = true;
                psi.Verb = "runas";
               
                Process.Start(psi);
            }

        }

    }

}
