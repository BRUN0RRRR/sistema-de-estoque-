namespace estoque
{
    partial class Form3
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
            produtos = new ComboBox();
            btnBaixar = new Button();
            nome = new TextBox();
            quantidade = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            data = new DateTimePicker();
            btnLimpar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // produtos
            // 
            produtos.FormattingEnabled = true;
            produtos.Location = new Point(115, 38);
            produtos.Name = "produtos";
            produtos.Size = new Size(200, 23);
            produtos.TabIndex = 0;
            // 
            // btnBaixar
            // 
            btnBaixar.Location = new Point(90, 190);
            btnBaixar.Name = "btnBaixar";
            btnBaixar.Size = new Size(75, 23);
            btnBaixar.TabIndex = 1;
            btnBaixar.Text = "Baixar";
            btnBaixar.UseVisualStyleBackColor = true;
            btnBaixar.Click += btnBaixar_Click;
            // 
            // nome
            // 
            nome.Location = new Point(115, 67);
            nome.Name = "nome";
            nome.Size = new Size(200, 23);
            nome.TabIndex = 2;
            // 
            // quantidade
            // 
            quantidade.Location = new Point(115, 96);
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(200, 23);
            quantidade.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(data);
            groupBox1.Controls.Add(produtos);
            groupBox1.Controls.Add(quantidade);
            groupBox1.Controls.Add(nome);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 172);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Baixa de Produtos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 131);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 8;
            label4.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 70);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 7;
            label3.Text = "Nome Colaborador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 99);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "Quantidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome do Produto";
            // 
            // data
            // 
            data.Location = new Point(115, 125);
            data.Name = "data";
            data.Size = new Size(200, 23);
            data.TabIndex = 4;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(185, 190);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 239);
            Controls.Add(btnLimpar);
            Controls.Add(groupBox1);
            Controls.Add(btnBaixar);
            Name = "Form3";
            Text = "Baixar de Produtos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox produtos;
        private Button btnBaixar;
        private TextBox nome;
        private TextBox quantidade;
        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker data;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnLimpar;
    }
}