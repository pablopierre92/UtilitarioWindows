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
            btn_Corrige = new Button();
            btn_chkdsk = new Button();
            groupBox2 = new GroupBox();
            btn_exportar = new Button();
            groupBox3 = new GroupBox();
            btn_importar = new Button();
            btn_Max = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Temp
            // 
            btn_Temp.Location = new Point(15, 33);
            btn_Temp.Name = "btn_Temp";
            btn_Temp.Size = new Size(112, 23);
            btn_Temp.TabIndex = 0;
            btn_Temp.Text = "Limpar";
            btn_Temp.UseVisualStyleBackColor = true;
            btn_Temp.Click += btn_Temp_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Temp);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(163, 90);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Limpeza";
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
            btn_Max.Location = new Point(253, 243);
            btn_Max.Name = "btn_Max";
            btn_Max.Size = new Size(75, 23);
            btn_Max.TabIndex = 7;
            btn_Max.Text = "button1";
            btn_Max.UseVisualStyleBackColor = true;
            btn_Max.Click += btn_Max_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 356);
            Controls.Add(btn_Max);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PPN";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
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
    }
}
