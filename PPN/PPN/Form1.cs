using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;

namespace PPN
{
    public partial class Form1 : Form
    {
        public object MessageDialog { get; private set; }

        public Form1()
        {
            InitializeComponent();

        }

        string comando = "";

        public void ExecutaCmd()
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c " + comando;
            psi.UseShellExecute = true; // Usa o shell para iniciar o processo
            psi.Verb = "runas"; // Executa como administrador

            Process.Start(psi);
        }

        private void btn_Temp_Click(object sender, EventArgs e)
        {
            string tempPath = Path.GetTempPath();
            CleanDirectory(tempPath);

            // Pasta %Temp%
            comando = "Del /S /F /Q %temp%";

            ExecutaCmd();

            // Pasta Prefetch
            string prefetchPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Prefetch");
            CleanDirectory(prefetchPath);

            // Pasta Recent
            string recentPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Recent));
            CleanDirectory(recentPath);

            //Esvazia Lixeira
            string comando2 = "rd /s /q C:\\$Recycle.Bin";

            ProcessStartInfo psi2 = new ProcessStartInfo();
            psi2.FileName = "cmd.exe";
            psi2.Arguments = "/c " + comando2;
            psi2.UseShellExecute = true;
            psi2.Verb = "runas";

            Process.Start(psi2);

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
            comando = "sfc /scannow";

            MessageBox.Show("Será feita a procura de erros no sistema e correção");

            ExecutaCmd();


        }

        private void btn_chkdsk_Click(object sender, EventArgs e)
        {
            comando = "chkdsk /r /f";

            MessageBox.Show("Quando começar digite Y e 'enter' para ser feita a verificação de disco quando reiniciar");

            ExecutaCmd();

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
                    MessageBox.Show("O backup será feiro em C:/BackupDrivers", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A pasta BackupDrivers em C: já existe, os arquivos serão copiados para ela", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                comando = "dism /online /export-driver /destination:C:\\BackupDrivers";


                ExecutaCmd();

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

                comando = "Dism /online /Add-Driver /Driver:{caminhoSelecionado} /Recurse";

                ExecutaCmd();
            }

        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            comando = "powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61";

            ExecutaCmd();

            DialogResult resultado = MessageBox.Show("Deseja ir ao painel de controle?", "Desempenho Máximo criado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            MessageBox.Show("Ao ativar o desempenho máximo, tenha certeza que seu computador esteja preparado para fazer o resfriamento das peças corretamente");

            if (resultado == DialogResult.Yes)
            {
                comando = "powercfg.cpl";

                ExecutaCmd();
            }
        }

        private void btn_limpezaDeDisco_Click(object sender, EventArgs e)
        {
            Process.Start("cleanmgr.exe");
        }

        private void btn_Notifc_Click(object sender, EventArgs e)
        {
            comando = "start ms-settings:notifications";

            ExecutaCmd();
        }

        private void btn_Sensor_Click(object sender, EventArgs e)
        {

            comando = "start ms-settings:storagesense";

            ExecutaCmd();
        }

        private void btn_OpcDes_Click(object sender, EventArgs e)
        {

            comando = "start SystemPropertiesPerformance.exe";

            ExecutaCmd();
        }

        private void btn_AntiVirus_Click(object sender, EventArgs e)
        {
            comando = "mrt.exe";

            ExecutaCmd();


        }

        private void btn_AddRem_Click(object sender, EventArgs e)
        {
            comando = "start appwiz.cpl";

            ExecutaCmd();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            comando = "start https://www.linkedin.com/in/pablo-pierre-04422ab6/";

            ExecutaCmd();
        }

        private void btn_OpcoesDeEnergia_Click(object sender, EventArgs e)
        {
            comando = "start powercfg.cpl";

            ExecutaCmd();
        }
    }
}

