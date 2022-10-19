namespace EntregaEncomendas
{
    partial class Form1
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
            this.gpbEncomenda = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.encomendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.entrega_encomendasDataSet1 = new EntregaEncomendas.entrega_encomendasDataSet1();
            this.entrega_encomendasDataSet = new EntregaEncomendas.entrega_encomendasDataSet();
            this.encomendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.encomendaTableAdapter = new EntregaEncomendas.entrega_encomendasDataSetTableAdapters.encomendaTableAdapter();
            this.btnCadastrarMorador = new System.Windows.Forms.Button();
            this.encomendaTableAdapter1 = new EntregaEncomendas.entrega_encomendasDataSet1TableAdapters.encomendaTableAdapter();
            this.entregasDataSet = new EntregaEncomendas.entregasDataSet();
            this.encomendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.encomendasTableAdapter = new EntregaEncomendas.entregasDataSetTableAdapters.encomendasTableAdapter();
            this.gpbEncomendasReg = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_morador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_retirada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_recebedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpbEncomenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrega_encomendasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrega_encomendasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomendasBindingSource)).BeginInit();
            this.gpbEncomendasReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbEncomenda
            // 
            this.gpbEncomenda.Controls.Add(this.txtNome);
            this.gpbEncomenda.Controls.Add(this.btnCadastrar);
            this.gpbEncomenda.Controls.Add(this.label1);
            this.gpbEncomenda.Location = new System.Drawing.Point(27, 34);
            this.gpbEncomenda.Name = "gpbEncomenda";
            this.gpbEncomenda.Size = new System.Drawing.Size(169, 190);
            this.gpbEncomenda.TabIndex = 1;
            this.gpbEncomenda.TabStop = false;
            this.gpbEncomenda.Text = "Cadastro Encomendas";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(24, 143);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(121, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar Encomenda";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destinatário:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome_morador,
            this.data_cadastro,
            this.data_retirada,
            this.nome_recebedor});
            this.dataGridView1.DataSource = this.encomendasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 278);
            this.dataGridView1.TabIndex = 2;
            // 
            // encomendaBindingSource1
            // 
            this.encomendaBindingSource1.DataMember = "encomenda";
            this.encomendaBindingSource1.DataSource = this.entrega_encomendasDataSet1;
            // 
            // entrega_encomendasDataSet1
            // 
            this.entrega_encomendasDataSet1.DataSetName = "entrega_encomendasDataSet1";
            this.entrega_encomendasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entrega_encomendasDataSet
            // 
            this.entrega_encomendasDataSet.DataSetName = "entrega_encomendasDataSet";
            this.entrega_encomendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // encomendaBindingSource
            // 
            this.encomendaBindingSource.DataMember = "encomenda";
            this.encomendaBindingSource.DataSource = this.entrega_encomendasDataSet;
            // 
            // encomendaTableAdapter
            // 
            this.encomendaTableAdapter.ClearBeforeFill = true;
            // 
            // btnCadastrarMorador
            // 
            this.btnCadastrarMorador.Location = new System.Drawing.Point(656, 188);
            this.btnCadastrarMorador.Name = "btnCadastrarMorador";
            this.btnCadastrarMorador.Size = new System.Drawing.Size(112, 23);
            this.btnCadastrarMorador.TabIndex = 3;
            this.btnCadastrarMorador.Text = "Cadastrar Morador";
            this.btnCadastrarMorador.UseVisualStyleBackColor = true;
            // 
            // encomendaTableAdapter1
            // 
            this.encomendaTableAdapter1.ClearBeforeFill = true;
            // 
            // entregasDataSet
            // 
            this.entregasDataSet.DataSetName = "entregasDataSet";
            this.entregasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // encomendasBindingSource
            // 
            this.encomendasBindingSource.DataMember = "encomendas";
            this.encomendasBindingSource.DataSource = this.entregasDataSet;
            // 
            // encomendasTableAdapter
            // 
            this.encomendasTableAdapter.ClearBeforeFill = true;
            // 
            // gpbEncomendasReg
            // 
            this.gpbEncomendasReg.Controls.Add(this.dataGridView1);
            this.gpbEncomendasReg.Location = new System.Drawing.Point(218, 34);
            this.gpbEncomendasReg.Name = "gpbEncomendasReg";
            this.gpbEncomendasReg.Size = new System.Drawing.Size(555, 314);
            this.gpbEncomendasReg.TabIndex = 5;
            this.gpbEncomendasReg.TabStop = false;
            this.gpbEncomendasReg.Text = "Encomendas Registradas";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome_morador
            // 
            this.nome_morador.DataPropertyName = "nome_morador";
            this.nome_morador.HeaderText = "nome_morador";
            this.nome_morador.Name = "nome_morador";
            this.nome_morador.ReadOnly = true;
            // 
            // data_cadastro
            // 
            this.data_cadastro.DataPropertyName = "data_cadastro";
            this.data_cadastro.HeaderText = "data_cadastro";
            this.data_cadastro.Name = "data_cadastro";
            this.data_cadastro.ReadOnly = true;
            // 
            // data_retirada
            // 
            this.data_retirada.DataPropertyName = "data_retirada";
            this.data_retirada.HeaderText = "data_retirada";
            this.data_retirada.Name = "data_retirada";
            this.data_retirada.ReadOnly = true;
            // 
            // nome_recebedor
            // 
            this.nome_recebedor.DataPropertyName = "nome_recebedor";
            this.nome_recebedor.HeaderText = "nome_recebedor";
            this.nome_recebedor.Name = "nome_recebedor";
            this.nome_recebedor.ReadOnly = true;
            // 
            // txtNome
            // 
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNome.Location = new System.Drawing.Point(25, 117);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(120, 20);
            this.txtNome.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 370);
            this.Controls.Add(this.gpbEncomendasReg);
            this.Controls.Add(this.btnCadastrarMorador);
            this.Controls.Add(this.gpbEncomenda);
            this.Name = "Form1";
            this.Text = "Encomendas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbEncomenda.ResumeLayout(false);
            this.gpbEncomenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrega_encomendasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrega_encomendasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomendasBindingSource)).EndInit();
            this.gpbEncomendasReg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbEncomenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private entrega_encomendasDataSet entrega_encomendasDataSet;
        private System.Windows.Forms.BindingSource encomendaBindingSource;
        private entrega_encomendasDataSetTableAdapters.encomendaTableAdapter encomendaTableAdapter;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCadastrarMorador;
        private entrega_encomendasDataSet1 entrega_encomendasDataSet1;
        private System.Windows.Forms.BindingSource encomendaBindingSource1;
        private entrega_encomendasDataSet1TableAdapters.encomendaTableAdapter encomendaTableAdapter1;
        private entregasDataSet entregasDataSet;
        private System.Windows.Forms.BindingSource encomendasBindingSource;
        private entregasDataSetTableAdapters.encomendasTableAdapter encomendasTableAdapter;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_morador;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_retirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_recebedor;
        private System.Windows.Forms.GroupBox gpbEncomendasReg;
    }
}

