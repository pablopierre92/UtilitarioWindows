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

		private void btn_Ativar_Click(object sender, EventArgs e)
		{
			comando = "slmgr -rearm";

			ExecutaCmd();
		}

		private void btn_DuvidaMostrarMais_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Remove ou adiciona o 'Mostrar mais' de quando clica com o botão direito no windows explorer deixando igual ao Windows 10");
		}

		private void btn_RemMostrarmais_Click(object sender, EventArgs e)
		{
			comando = "reg add “HKCU\\Software\\Classes\\CLSID\\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\\InprocServer32” /f /ve";
			ExecutaCmd();
		}

		private void btn_AddMostrarMais_Click(object sender, EventArgs e)
		{
			comando = "rg delete “HKCU\\Software\\Classes\\CLSID\\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}” /f";
			ExecutaCmd();
		}

		private void btn_GerarBat_Click(object sender, EventArgs e)
		{
			// Caminho para a área de trabalho do usuário
			string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			// Conteúdo do arquivo de lote (.bat)
			string batContent = "@echo off" + Environment.NewLine +
								"echo Desligando o computador..." + Environment.NewLine +
								"shutdown /s /t 0";

			// Caminho completo para o arquivo .bat
			string batFilePath = Path.Combine(desktopPath, "DesligarComputador.bat");

			try
			{
				// Escrever o conteúdo no arquivo .bat
				File.WriteAllText(batFilePath, batContent);

				MessageBox.Show("Arquivo .bat gerado com sucesso na área de trabalho.");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ocorreu um erro ao gerar o arquivo .bat: {ex.Message}");
			}
		}

		private void btn_GerarReiniciar_Click(object sender, EventArgs e)
		{
			// Caminho para a área de trabalho do usuário
			string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			// Conteúdo do arquivo de lote (.bat)
			string batContent = "@echo off" + Environment.NewLine +
								"echo Reiniciando o computador..." + Environment.NewLine +
								"shutdown /r /t 0";

			// Caminho completo para o arquivo .bat
			string batFilePath = Path.Combine(desktopPath, "ReiniciarComputador.bat");

			try
			{
				// Escrever o conteúdo no arquivo .bat
				File.WriteAllText(batFilePath, batContent);

				MessageBox.Show("Arquivo .bat gerado com sucesso na área de trabalho.");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ocorreu um erro ao gerar o arquivo .bat: {ex.Message}");
			}
		}

		private void btn_Uac_Click(object sender, EventArgs e)
		{
			comando = "reg.exe add \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\" /v EnableLUA /t REG_DWORD /d 0 /f";
			ExecutaCmd();

			DialogResult resultado = MessageBox.Show("Reinicie seu computador para a modificações fazerem efeito", "Reiniciar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			

			if (resultado == DialogResult.Yes)
			{
				comando = "shutdown /r /t 0"; 

				ExecutaCmd();
			}


		}
	}
}

