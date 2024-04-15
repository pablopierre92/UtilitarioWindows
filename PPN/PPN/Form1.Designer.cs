namespace PPN
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
            btn_Temp = new Button();
            groupBox1 = new GroupBox();
            btn_limpezaDeDisco = new Button();
            btn_Corrige = new Button();
            btn_chkdsk = new Button();
            groupBox2 = new GroupBox();
            btn_exportar = new Button();
            groupBox3 = new GroupBox();
            btn_importar = new Button();
            btn_Max = new Button();
            groupBox4 = new GroupBox();
            btn_Notifc = new Button();
            btn_Sensor = new Button();
            btn_OpcDes = new Button();
            groupBox5 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Temp
            // 
            btn_Temp.Location = new Point(6, 22);
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 90);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Limpeza";
            // 
            // btn_limpezaDeDisco
            // 
            btn_limpezaDeDisco.Location = new Point(6, 51);
            btn_limpezaDeDisco.Name = "btn_limpezaDeDisco";
            btn_limpezaDeDisco.Size = new Size(181, 23);
            btn_limpezaDeDisco.TabIndex = 1;
            btn_limpezaDeDisco.Text = "Limpeza de Disco";
            btn_limpezaDeDisco.UseVisualStyleBackColor = true;
            btn_limpezaDeDisco.Click += btn_limpezaDeDisco_Click;
            // 
            // btn_Corrige
            // 
            btn_Corrige.Location = new Point(6, 36);
            btn_Corrige.Name = "btn_Corrige";
            btn_Corrige.Size = new Size(75, 23);
            btn_Corrige.TabIndex = 2;
            btn_Corrige.Text = "sfc";
            btn_Corrige.UseVisualStyleBackColor = true;
            btn_Corrige.Click += btn_Corrige_Click;
            // 
            // btn_chkdsk
            // 
            btn_chkdsk.Location = new Point(101, 36);
            btn_chkdsk.Name = "btn_chkdsk";
            btn_chkdsk.Size = new Size(75, 23);
            btn_chkdsk.TabIndex = 3;
            btn_chkdsk.Text = "chkdsk";
            btn_chkdsk.UseVisualStyleBackColor = true;
            btn_chkdsk.Click += btn_chkdsk_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Corrige);
            groupBox2.Controls.Add(btn_chkdsk);
            groupBox2.Location = new Point(12, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Correção";
            // 
            // btn_exportar
            // 
            btn_exportar.Location = new Point(20, 43);
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
            groupBox3.Location = new Point(12, 223);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Drivers";
            // 
            // btn_importar
            // 
            btn_importar.Location = new Point(112, 43);
            btn_importar.Name = "btn_importar";
            btn_importar.Size = new Size(75, 23);
            btn_importar.TabIndex = 7;
            btn_importar.Text = "Importar";
            btn_importar.UseVisualStyleBackColor = true;
            btn_importar.Click += btn_importar_Click;
            // 
            // btn_Max
            // 
            btn_Max.Location = new Point(9, 22);
            btn_Max.Name = "btn_Max";
            btn_Max.Size = new Size(75, 23);
            btn_Max.TabIndex = 7;
            btn_Max.Text = "Máximo";
            btn_Max.UseVisualStyleBackColor = true;
            btn_Max.Click += btn_Max_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_Max);
            groupBox4.Location = new Point(256, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(198, 90);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Energia";
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
            btn_Sensor.Location = new Point(17, 52);
            btn_Sensor.Name = "btn_Sensor";
            btn_Sensor.Size = new Size(161, 23);
            btn_Sensor.TabIndex = 10;
            btn_Sensor.Text = "Sensor de Armazenamento";
            btn_Sensor.UseVisualStyleBackColor = true;
            btn_Sensor.Click += btn_Sensor_Click;
            // 
            // btn_OpcDes
            // 
            btn_OpcDes.Location = new Point(17, 83);
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
            groupBox5.Location = new Point(254, 123);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 117);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "Otimizar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 356);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PPN";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}
