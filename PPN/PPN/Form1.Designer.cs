﻿namespace PPN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_Temp = new Button();
            groupBox1 = new GroupBox();
            btn_limpezaDeDisco = new Button();
            btn_Corrige = new Button();
            btn_chkdsk = new Button();
            groupBox2 = new GroupBox();
            btn_ReiniciarExplorer = new Button();
            btn_Dism = new Button();
            btn_exportar = new Button();
            groupBox3 = new GroupBox();
            btn_importar = new Button();
            btn_Max = new Button();
            groupBox4 = new GroupBox();
            btn_OpcoesDeEnergia = new Button();
            btn_Notifc = new Button();
            btn_Sensor = new Button();
            btn_OpcDes = new Button();
            groupBox5 = new GroupBox();
            btn_AntiVirus = new Button();
            btn_AddRem = new Button();
            linkLabel1 = new LinkLabel();
            btn_Ativar = new Button();
            groupBox6 = new GroupBox();
            btn_DuvidaMostrarMais = new Button();
            label1 = new Label();
            btn_AddMostrarMais = new Button();
            btn_RemMostrarmais = new Button();
            btn_GerarBat = new Button();
            groupBox7 = new GroupBox();
            btn_GerarReiniciar = new Button();
            btn_Uac = new Button();
            btn_InfSis = new Button();
            btn_Key = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Temp
            // 
            btn_Temp.Location = new Point(22, 22);
            btn_Temp.Name = "btn_Temp";
            btn_Temp.Size = new Size(181, 23);
            btn_Temp.TabIndex = 0;
            btn_Temp.Text = "Temp/Prefetch/Recent/Lixeira";
            btn_Temp.UseVisualStyleBackColor = true;
            btn_Temp.Click += btn_Temp_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_limpezaDeDisco);
            groupBox1.Controls.Add(btn_Temp);
            groupBox1.Location = new Point(12, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 90);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Limpeza";
            // 
            // btn_limpezaDeDisco
            // 
            btn_limpezaDeDisco.Location = new Point(23, 51);
            btn_limpezaDeDisco.Name = "btn_limpezaDeDisco";
            btn_limpezaDeDisco.Size = new Size(181, 23);
            btn_limpezaDeDisco.TabIndex = 1;
            btn_limpezaDeDisco.Text = "Limpeza de Disco";
            btn_limpezaDeDisco.UseVisualStyleBackColor = true;
            btn_limpezaDeDisco.Click += btn_limpezaDeDisco_Click;
            // 
            // btn_Corrige
            // 
            btn_Corrige.Location = new Point(20, 22);
            btn_Corrige.Name = "btn_Corrige";
            btn_Corrige.Size = new Size(75, 23);
            btn_Corrige.TabIndex = 2;
            btn_Corrige.Text = "sfc";
            btn_Corrige.UseVisualStyleBackColor = true;
            btn_Corrige.Click += btn_Corrige_Click;
            // 
            // btn_chkdsk
            // 
            btn_chkdsk.Location = new Point(108, 22);
            btn_chkdsk.Name = "btn_chkdsk";
            btn_chkdsk.Size = new Size(75, 23);
            btn_chkdsk.TabIndex = 3;
            btn_chkdsk.Text = "chkdsk";
            btn_chkdsk.UseVisualStyleBackColor = true;
            btn_chkdsk.Click += btn_chkdsk_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_ReiniciarExplorer);
            groupBox2.Controls.Add(btn_Dism);
            groupBox2.Controls.Add(btn_Corrige);
            groupBox2.Controls.Add(btn_chkdsk);
            groupBox2.Location = new Point(12, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(227, 96);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Correção";
            // 
            // btn_ReiniciarExplorer
            // 
            btn_ReiniciarExplorer.Location = new Point(108, 60);
            btn_ReiniciarExplorer.Name = "btn_ReiniciarExplorer";
            btn_ReiniciarExplorer.Size = new Size(108, 23);
            btn_ReiniciarExplorer.TabIndex = 22;
            btn_ReiniciarExplorer.Text = "Reiniciar Explorer";
            btn_ReiniciarExplorer.UseVisualStyleBackColor = true;
            btn_ReiniciarExplorer.Click += btn_ReiniciarExplorer_Click;
            // 
            // btn_Dism
            // 
            btn_Dism.Location = new Point(20, 60);
            btn_Dism.Name = "btn_Dism";
            btn_Dism.Size = new Size(75, 23);
            btn_Dism.TabIndex = 22;
            btn_Dism.Text = "DISM";
            btn_Dism.UseVisualStyleBackColor = true;
            btn_Dism.Click += btn_Dism_Click;
            // 
            // btn_exportar
            // 
            btn_exportar.Location = new Point(20, 28);
            btn_exportar.Name = "btn_exportar";
            btn_exportar.Size = new Size(75, 23);
            btn_exportar.TabIndex = 5;
            btn_exportar.Text = "Exportar";
            btn_exportar.UseVisualStyleBackColor = true;
            btn_exportar.Click += btn_exportar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_importar);
            groupBox3.Controls.Add(btn_exportar);
            groupBox3.Location = new Point(12, 241);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(227, 69);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Drivers";
            // 
            // btn_importar
            // 
            btn_importar.Location = new Point(124, 28);
            btn_importar.Name = "btn_importar";
            btn_importar.Size = new Size(75, 23);
            btn_importar.TabIndex = 7;
            btn_importar.Text = "Importar";
            btn_importar.UseVisualStyleBackColor = true;
            btn_importar.Click += btn_importar_Click;
            // 
            // btn_Max
            // 
            btn_Max.Location = new Point(26, 22);
            btn_Max.Name = "btn_Max";
            btn_Max.Size = new Size(140, 23);
            btn_Max.TabIndex = 7;
            btn_Max.Text = "Máximo Desempenho";
            btn_Max.UseVisualStyleBackColor = true;
            btn_Max.Click += btn_Max_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_OpcoesDeEnergia);
            groupBox4.Controls.Add(btn_Max);
            groupBox4.Location = new Point(286, 43);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(198, 90);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Energia";
            // 
            // btn_OpcoesDeEnergia
            // 
            btn_OpcoesDeEnergia.Location = new Point(26, 53);
            btn_OpcoesDeEnergia.Name = "btn_OpcoesDeEnergia";
            btn_OpcoesDeEnergia.Size = new Size(140, 23);
            btn_OpcoesDeEnergia.TabIndex = 8;
            btn_OpcoesDeEnergia.Text = "Opções de Energia";
            btn_OpcoesDeEnergia.UseVisualStyleBackColor = true;
            btn_OpcoesDeEnergia.Click += btn_OpcoesDeEnergia_Click;
            // 
            // btn_Notifc
            // 
            btn_Notifc.Location = new Point(17, 22);
            btn_Notifc.Name = "btn_Notifc";
            btn_Notifc.Size = new Size(161, 23);
            btn_Notifc.TabIndex = 9;
            btn_Notifc.Text = "Notificacões e Ações";
            btn_Notifc.UseVisualStyleBackColor = true;
            btn_Notifc.Click += btn_Notifc_Click;
            // 
            // btn_Sensor
            // 
            btn_Sensor.Location = new Point(17, 51);
            btn_Sensor.Name = "btn_Sensor";
            btn_Sensor.Size = new Size(161, 23);
            btn_Sensor.TabIndex = 10;
            btn_Sensor.Text = "Sensor de Armazenamento";
            btn_Sensor.UseVisualStyleBackColor = true;
            btn_Sensor.Click += btn_Sensor_Click;
            // 
            // btn_OpcDes
            // 
            btn_OpcDes.Location = new Point(17, 81);
            btn_OpcDes.Name = "btn_OpcDes";
            btn_OpcDes.Size = new Size(161, 23);
            btn_OpcDes.TabIndex = 11;
            btn_OpcDes.Text = "Opções de Desempenho";
            btn_OpcDes.UseVisualStyleBackColor = true;
            btn_OpcDes.Click += btn_OpcDes_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btn_Notifc);
            groupBox5.Controls.Add(btn_OpcDes);
            groupBox5.Controls.Add(btn_Sensor);
            groupBox5.Location = new Point(284, 148);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 141);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "Otimizar";
            // 
            // btn_AntiVirus
            // 
            btn_AntiVirus.Location = new Point(12, 429);
            btn_AntiVirus.Name = "btn_AntiVirus";
            btn_AntiVirus.Size = new Size(95, 23);
            btn_AntiVirus.TabIndex = 13;
            btn_AntiVirus.Text = "Anti-Vírus";
            btn_AntiVirus.UseVisualStyleBackColor = true;
            btn_AntiVirus.Click += btn_AntiVirus_Click;
            // 
            // btn_AddRem
            // 
            btn_AddRem.Location = new Point(301, 260);
            btn_AddRem.Name = "btn_AddRem";
            btn_AddRem.Size = new Size(161, 23);
            btn_AddRem.TabIndex = 14;
            btn_AddRem.Text = "Add / Remover Programas";
            btn_AddRem.UseVisualStyleBackColor = true;
            btn_AddRem.Click += btn_AddRem_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(364, 462);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(135, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Pablo Pierre da Nóbrega";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btn_Ativar
            // 
            btn_Ativar.Location = new Point(120, 429);
            btn_Ativar.Name = "btn_Ativar";
            btn_Ativar.Size = new Size(119, 23);
            btn_Ativar.TabIndex = 17;
            btn_Ativar.Text = "Reativar Windows";
            btn_Ativar.UseVisualStyleBackColor = true;
            btn_Ativar.Click += btn_Ativar_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btn_DuvidaMostrarMais);
            groupBox6.Controls.Add(label1);
            groupBox6.Controls.Add(btn_AddMostrarMais);
            groupBox6.Controls.Add(btn_RemMostrarmais);
            groupBox6.Location = new Point(286, 315);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(198, 106);
            groupBox6.TabIndex = 18;
            groupBox6.TabStop = false;
            groupBox6.Text = "Windows 11";
            // 
            // btn_DuvidaMostrarMais
            // 
            btn_DuvidaMostrarMais.Location = new Point(116, 15);
            btn_DuvidaMostrarMais.Name = "btn_DuvidaMostrarMais";
            btn_DuvidaMostrarMais.Size = new Size(21, 22);
            btn_DuvidaMostrarMais.TabIndex = 3;
            btn_DuvidaMostrarMais.Text = "?";
            btn_DuvidaMostrarMais.UseVisualStyleBackColor = true;
            btn_DuvidaMostrarMais.Click += btn_DuvidaMostrarMais_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 22);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 2;
            label1.Text = "Windows Explorer";
            // 
            // btn_AddMostrarMais
            // 
            btn_AddMostrarMais.Location = new Point(15, 73);
            btn_AddMostrarMais.Name = "btn_AddMostrarMais";
            btn_AddMostrarMais.Size = new Size(151, 23);
            btn_AddMostrarMais.TabIndex = 1;
            btn_AddMostrarMais.Text = "Adicionar \"Mostrar mais\"";
            btn_AddMostrarMais.UseVisualStyleBackColor = true;
            btn_AddMostrarMais.Click += btn_AddMostrarMais_Click;
            // 
            // btn_RemMostrarmais
            // 
            btn_RemMostrarmais.Location = new Point(15, 44);
            btn_RemMostrarmais.Name = "btn_RemMostrarmais";
            btn_RemMostrarmais.Size = new Size(151, 23);
            btn_RemMostrarmais.TabIndex = 0;
            btn_RemMostrarmais.Text = "Remover \"Mostrar mais\"";
            btn_RemMostrarmais.UseVisualStyleBackColor = true;
            btn_RemMostrarmais.Click += btn_RemMostrarmais_Click;
            // 
            // btn_GerarBat
            // 
            btn_GerarBat.Location = new Point(20, 29);
            btn_GerarBat.Name = "btn_GerarBat";
            btn_GerarBat.Size = new Size(75, 23);
            btn_GerarBat.TabIndex = 19;
            btn_GerarBat.Text = "Desligar";
            btn_GerarBat.UseVisualStyleBackColor = true;
            btn_GerarBat.Click += btn_GerarBat_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(btn_GerarReiniciar);
            groupBox7.Controls.Add(btn_GerarBat);
            groupBox7.Location = new Point(12, 330);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(227, 69);
            groupBox7.TabIndex = 20;
            groupBox7.TabStop = false;
            groupBox7.Text = "Gerar Arquivo .BAT";
            // 
            // btn_GerarReiniciar
            // 
            btn_GerarReiniciar.Location = new Point(122, 29);
            btn_GerarReiniciar.Name = "btn_GerarReiniciar";
            btn_GerarReiniciar.Size = new Size(75, 23);
            btn_GerarReiniciar.TabIndex = 20;
            btn_GerarReiniciar.Text = "Reiniciar";
            btn_GerarReiniciar.UseVisualStyleBackColor = true;
            btn_GerarReiniciar.Click += btn_GerarReiniciar_Click;
            // 
            // btn_Uac
            // 
            btn_Uac.Location = new Point(12, 14);
            btn_Uac.Name = "btn_Uac";
            btn_Uac.Size = new Size(110, 23);
            btn_Uac.TabIndex = 21;
            btn_Uac.Text = "Desabilitar UAC";
            btn_Uac.UseVisualStyleBackColor = true;
            btn_Uac.Click += btn_Uac_Click;
            // 
            // btn_InfSis
            // 
            btn_InfSis.Location = new Point(128, 14);
            btn_InfSis.Name = "btn_InfSis";
            btn_InfSis.Size = new Size(147, 23);
            btn_InfSis.TabIndex = 22;
            btn_InfSis.Text = "Informações do Sistema";
            btn_InfSis.UseVisualStyleBackColor = true;
            btn_InfSis.Click += btn_InfSis_Click;
            // 
            // btn_Key
            // 
            btn_Key.Location = new Point(280, 14);
            btn_Key.Name = "btn_Key";
            btn_Key.Size = new Size(205, 23);
            btn_Key.TabIndex = 23;
            btn_Key.Text = "Mostrar Chave do Windows";
            btn_Key.UseVisualStyleBackColor = true;
            btn_Key.Click += btn_Key_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 461);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 24;
            label2.Text = "Desenvolvido por";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 486);
            Controls.Add(label2);
            Controls.Add(btn_Key);
            Controls.Add(btn_InfSis);
            Controls.Add(btn_Uac);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(btn_Ativar);
            Controls.Add(linkLabel1);
            Controls.Add(btn_AddRem);
            Controls.Add(btn_AntiVirus);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PPN";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Temp;
        private GroupBox groupBox1;
        private Button btn_Corrige;
        private Button btn_chkdsk;
        private GroupBox groupBox2;
        private Button btn_exportar;
        private GroupBox groupBox3;
        private Button btn_importar;
        private Button btn_Max;
        private GroupBox groupBox4;
        private Button btn_limpezaDeDisco;
        private Button btn_Notifc;
        private Button btn_Sensor;
        private Button btn_OpcDes;
        private GroupBox groupBox5;
        private Button btn_AntiVirus;
        private Button btn_AddRem;
        private Button btn_OpcoesDeEnergia;
        protected LinkLabel linkLabel1;
		private Button btn_Ativar;
		private GroupBox groupBox6;
		private Label label1;
		private Button btn_AddMostrarMais;
		private Button btn_RemMostrarmais;
		private Button btn_DuvidaMostrarMais;
		private Button btn_GerarBat;
		private GroupBox groupBox7;
		private Button btn_GerarReiniciar;
		private Button btn_Uac;
        private Button btn_Dism;
        private Button btn_ReiniciarExplorer;
        private Button btn_InfSis;
        private Button btn_Key;
        private Label label2;
    }
}
