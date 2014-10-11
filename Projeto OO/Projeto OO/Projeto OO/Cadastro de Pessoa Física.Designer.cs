namespace Projeto_OO
{
    partial class CadastrarPF
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
            this.BotãoSalvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NOME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DATA_DE_NASCIMENTO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ENDEREÇO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ESTADO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CEP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TELEFONES = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BotãoSalvar
            // 
            this.BotãoSalvar.Location = new System.Drawing.Point(292, 306);
            this.BotãoSalvar.Name = "BotãoSalvar";
            this.BotãoSalvar.Size = new System.Drawing.Size(75, 23);
            this.BotãoSalvar.TabIndex = 19;
            this.BotãoSalvar.Text = "Salvar";
            this.BotãoSalvar.UseVisualStyleBackColor = true;
            this.BotãoSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome:";
            // 
            // NOME
            // 
            this.NOME.Location = new System.Drawing.Point(79, 24);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(385, 20);
            this.NOME.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "CPF:";
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(79, 60);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(129, 20);
            this.CPF.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Data de nascimento:";
            // 
            // DATA_DE_NASCIMENTO
            // 
            this.DATA_DE_NASCIMENTO.Location = new System.Drawing.Point(146, 94);
            this.DATA_DE_NASCIMENTO.Name = "DATA_DE_NASCIMENTO";
            this.DATA_DE_NASCIMENTO.Size = new System.Drawing.Size(100, 20);
            this.DATA_DE_NASCIMENTO.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Endereço:";
            // 
            // ENDEREÇO
            // 
            this.ENDEREÇO.Location = new System.Drawing.Point(100, 131);
            this.ENDEREÇO.Name = "ENDEREÇO";
            this.ENDEREÇO.Size = new System.Drawing.Size(364, 20);
            this.ENDEREÇO.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Estado:";
            // 
            // ESTADO
            // 
            this.ESTADO.Location = new System.Drawing.Point(87, 168);
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.Size = new System.Drawing.Size(164, 20);
            this.ESTADO.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "CEP:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CEP
            // 
            this.CEP.Location = new System.Drawing.Point(326, 168);
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(138, 20);
            this.CEP.TabIndex = 32;
            this.CEP.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Email:";
            // 
            // EMAIL
            // 
            this.EMAIL.Location = new System.Drawing.Point(87, 210);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(255, 20);
            this.EMAIL.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Telefones:";
            // 
            // TELEFONES
            // 
            this.TELEFONES.Location = new System.Drawing.Point(100, 249);
            this.TELEFONES.Name = "TELEFONES";
            this.TELEFONES.Size = new System.Drawing.Size(242, 20);
            this.TELEFONES.TabIndex = 36;
            // 
            // CadastrarPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 341);
            this.Controls.Add(this.TELEFONES);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CEP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ESTADO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ENDEREÇO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DATA_DE_NASCIMENTO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NOME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BotãoSalvar);
            this.Name = "CadastrarPF";
            this.Text = "Cadastrar Pessoa Física";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotãoSalvar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NOME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DATA_DE_NASCIMENTO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ENDEREÇO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ESTADO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CEP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EMAIL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TELEFONES;
    }
}