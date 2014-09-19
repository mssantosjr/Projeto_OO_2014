namespace Projeto_OO
{
    partial class Consultar_Hardware
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
            this.label1 = new System.Windows.Forms.Label();
            this.ConsultaBox = new System.Windows.Forms.TextBox();
            this.ListarTudo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodEquipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApagarBotão = new System.Windows.Forms.Button();
            this.EditarBotão = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Campo de Busca:";
            // 
            // ConsultaBox
            // 
            this.ConsultaBox.Location = new System.Drawing.Point(123, 15);
            this.ConsultaBox.Name = "ConsultaBox";
            this.ConsultaBox.Size = new System.Drawing.Size(198, 20);
            this.ConsultaBox.TabIndex = 1;
            // 
            // ListarTudo
            // 
            this.ListarTudo.Location = new System.Drawing.Point(367, 12);
            this.ListarTudo.Name = "ListarTudo";
            this.ListarTudo.Size = new System.Drawing.Size(75, 23);
            this.ListarTudo.TabIndex = 3;
            this.ListarTudo.Text = "Listar Tudo";
            this.ListarTudo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodEquipamento,
            this.Tipo,
            this.MarcaModelo,
            this.Preço,
            this.Quantidade,
            this.Descrição});
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 325);
            this.dataGridView1.TabIndex = 4;
            // 
            // CodEquipamento
            // 
            this.CodEquipamento.HeaderText = "Cod. Equipamento";
            this.CodEquipamento.Name = "CodEquipamento";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // MarcaModelo
            // 
            this.MarcaModelo.HeaderText = "Marca/Modelo";
            this.MarcaModelo.Name = "MarcaModelo";
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            // 
            // ApagarBotão
            // 
            this.ApagarBotão.Location = new System.Drawing.Point(563, 434);
            this.ApagarBotão.Name = "ApagarBotão";
            this.ApagarBotão.Size = new System.Drawing.Size(75, 23);
            this.ApagarBotão.TabIndex = 5;
            this.ApagarBotão.Text = "Apagar";
            this.ApagarBotão.UseVisualStyleBackColor = true;
            this.ApagarBotão.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditarBotão
            // 
            this.EditarBotão.Location = new System.Drawing.Point(471, 434);
            this.EditarBotão.Name = "EditarBotão";
            this.EditarBotão.Size = new System.Drawing.Size(75, 23);
            this.EditarBotão.TabIndex = 6;
            this.EditarBotão.Text = "Editar";
            this.EditarBotão.UseVisualStyleBackColor = true;
            this.EditarBotão.Click += new System.EventHandler(this.button2_Click);
            // 
            // Consultar_Hardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 485);
            this.Controls.Add(this.EditarBotão);
            this.Controls.Add(this.ApagarBotão);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ListarTudo);
            this.Controls.Add(this.ConsultaBox);
            this.Controls.Add(this.label1);
            this.Name = "Consultar_Hardware";
            this.Text = "Consulta de Hardware";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConsultaBox;
        private System.Windows.Forms.Button ListarTudo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEquipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.Button ApagarBotão;
        private System.Windows.Forms.Button EditarBotão;
    }
}