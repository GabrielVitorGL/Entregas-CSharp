namespace EntregaEncomendas
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNumApt = new System.Windows.Forms.Label();
            this.txtBlocApto = new System.Windows.Forms.TextBox();
            this.lblBlocoApto = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.nudNumeroApto = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroApto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(54, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(150, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(149, 91);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 3;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(54, 94);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(26, 13);
            this.lblRg.TabIndex = 2;
            this.lblRg.Text = "RG:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(148, 143);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 5;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(54, 146);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNumApt
            // 
            this.lblNumApt.AutoSize = true;
            this.lblNumApt.Location = new System.Drawing.Point(54, 191);
            this.lblNumApt.Name = "lblNumApt";
            this.lblNumApt.Size = new System.Drawing.Size(87, 13);
            this.lblNumApt.TabIndex = 6;
            this.lblNumApt.Text = "Numero do Apto:";
            // 
            // txtBlocApto
            // 
            this.txtBlocApto.Location = new System.Drawing.Point(148, 226);
            this.txtBlocApto.Name = "txtBlocApto";
            this.txtBlocApto.Size = new System.Drawing.Size(100, 20);
            this.txtBlocApto.TabIndex = 9;
            // 
            // lblBlocoApto
            // 
            this.lblBlocoApto.AutoSize = true;
            this.lblBlocoApto.Location = new System.Drawing.Point(54, 229);
            this.lblBlocoApto.Name = "lblBlocoApto";
            this.lblBlocoApto.Size = new System.Drawing.Size(77, 13);
            this.lblBlocoApto.TabIndex = 8;
            this.lblBlocoApto.Text = "Bloco do Apto:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nudNumeroApto
            // 
            this.nudNumeroApto.Location = new System.Drawing.Point(150, 191);
            this.nudNumeroApto.Name = "nudNumeroApto";
            this.nudNumeroApto.Size = new System.Drawing.Size(120, 20);
            this.nudNumeroApto.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudNumeroApto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBlocApto);
            this.Controls.Add(this.lblBlocoApto);
            this.Controls.Add(this.lblNumApt);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroApto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNumApt;
        private System.Windows.Forms.TextBox txtBlocApto;
        private System.Windows.Forms.Label lblBlocoApto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudNumeroApto;
    }
}