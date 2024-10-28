namespace estoque
{
    partial class Form4
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
            Produto = new ComboBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            edit_marca = new TextBox();
            edit_produto = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Produto
            // 
            Produto.FormattingEnabled = true;
            Produto.Location = new Point(144, 22);
            Produto.Name = "Produto";
            Produto.Size = new Size(177, 23);
            Produto.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(233, 136);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(edit_marca);
            groupBox1.Controls.Add(edit_produto);
            groupBox1.Controls.Add(Produto);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 184);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar";
            // 
            // button2
            // 
            button2.Location = new Point(233, 97);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 25);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 5;
            label3.Text = "Escolha um Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 118);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Marca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 62);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome do produto";
            // 
            // edit_marca
            // 
            edit_marca.Location = new Point(21, 136);
            edit_marca.Name = "edit_marca";
            edit_marca.Size = new Size(185, 23);
            edit_marca.TabIndex = 2;
            // 
            // edit_produto
            // 
            edit_produto.Location = new Point(21, 80);
            edit_produto.Name = "edit_produto";
            edit_produto.Size = new Size(185, 23);
            edit_produto.TabIndex = 1;
            edit_produto.Text = "\r\n";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 225);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Editar Produtos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox Produto;
        private Button button1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox edit_marca;
        private TextBox edit_produto;
        private Label label3;
        private Button button2;
    }
}