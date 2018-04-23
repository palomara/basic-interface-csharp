namespace CalculoMedia
{
    partial class frmMedia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAluno = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lbl1Bim = new System.Windows.Forms.Label();
            this.txb1Bim = new System.Windows.Forms.TextBox();
            this.lbl2Bim = new System.Windows.Forms.Label();
            this.txb2Bim = new System.Windows.Forms.TextBox();
            this.lbl3Bim = new System.Windows.Forms.Label();
            this.lbl4Bim = new System.Windows.Forms.Label();
            this.txb4Bim = new System.Windows.Forms.TextBox();
            this.txb3Bim = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(76, 39);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(80, 13);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Nome do Aluno";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(170, 36);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 1;
            // 
            // lbl1Bim
            // 
            this.lbl1Bim.AutoSize = true;
            this.lbl1Bim.Location = new System.Drawing.Point(37, 92);
            this.lbl1Bim.Name = "lbl1Bim";
            this.lbl1Bim.Size = new System.Drawing.Size(37, 13);
            this.lbl1Bim.TabIndex = 2;
            this.lbl1Bim.Text = "1º Bim";
            // 
            // txb1Bim
            // 
            this.txb1Bim.Location = new System.Drawing.Point(92, 89);
            this.txb1Bim.Multiline = true;
            this.txb1Bim.Name = "txb1Bim";
            this.txb1Bim.Size = new System.Drawing.Size(100, 23);
            this.txb1Bim.TabIndex = 3;
            // 
            // lbl2Bim
            // 
            this.lbl2Bim.AutoSize = true;
            this.lbl2Bim.Location = new System.Drawing.Point(220, 92);
            this.lbl2Bim.Name = "lbl2Bim";
            this.lbl2Bim.Size = new System.Drawing.Size(37, 13);
            this.lbl2Bim.TabIndex = 4;
            this.lbl2Bim.Text = "2º Bim";
            // 
            // txb2Bim
            // 
            this.txb2Bim.Location = new System.Drawing.Point(287, 92);
            this.txb2Bim.Name = "txb2Bim";
            this.txb2Bim.Size = new System.Drawing.Size(100, 20);
            this.txb2Bim.TabIndex = 5;
            // 
            // lbl3Bim
            // 
            this.lbl3Bim.AutoSize = true;
            this.lbl3Bim.Location = new System.Drawing.Point(37, 135);
            this.lbl3Bim.Name = "lbl3Bim";
            this.lbl3Bim.Size = new System.Drawing.Size(37, 13);
            this.lbl3Bim.TabIndex = 6;
            this.lbl3Bim.Text = "3º Bim";
            // 
            // lbl4Bim
            // 
            this.lbl4Bim.AutoSize = true;
            this.lbl4Bim.Location = new System.Drawing.Point(220, 135);
            this.lbl4Bim.Name = "lbl4Bim";
            this.lbl4Bim.Size = new System.Drawing.Size(37, 13);
            this.lbl4Bim.TabIndex = 7;
            this.lbl4Bim.Text = "4º Bim";
            // 
            // txb4Bim
            // 
            this.txb4Bim.Location = new System.Drawing.Point(287, 135);
            this.txb4Bim.Name = "txb4Bim";
            this.txb4Bim.Size = new System.Drawing.Size(100, 20);
            this.txb4Bim.TabIndex = 8;
            // 
            // txb3Bim
            // 
            this.txb3Bim.Location = new System.Drawing.Point(92, 135);
            this.txb3Bim.Name = "txb3Bim";
            this.txb3Bim.Size = new System.Drawing.Size(100, 20);
            this.txb3Bim.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(170, 180);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.BackColorChanged += new System.EventHandler(this.btnCalcular_Click);
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(187, 219);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(10, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "-";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(187, 256);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(10, 13);
            this.lblMedia.TabIndex = 12;
            this.lblMedia.Text = "-";
            // 
            // frmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 278);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txb3Bim);
            this.Controls.Add(this.txb4Bim);
            this.Controls.Add(this.lbl4Bim);
            this.Controls.Add(this.lbl3Bim);
            this.Controls.Add(this.txb2Bim);
            this.Controls.Add(this.lbl2Bim);
            this.Controls.Add(this.txb1Bim);
            this.Controls.Add(this.lbl1Bim);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblAluno);
            this.Name = "frmMedia";
            this.Text = "Cálculo da Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lbl1Bim;
        private System.Windows.Forms.TextBox txb1Bim;
        private System.Windows.Forms.Label lbl2Bim;
        private System.Windows.Forms.TextBox txb2Bim;
        private System.Windows.Forms.Label lbl3Bim;
        private System.Windows.Forms.Label lbl4Bim;
        private System.Windows.Forms.TextBox txb4Bim;
        private System.Windows.Forms.TextBox txb3Bim;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMedia;
    }
}

