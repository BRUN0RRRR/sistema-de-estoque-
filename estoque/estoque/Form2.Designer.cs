namespace estoque
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
            nomeProdu = new TextBox();
            marcaProd = new TextBox();
            quantidadeProd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            dataProd = new DateTimePicker();
            btnCadas = new Button();
            btnlimpar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nomeProdu
            // 
            nomeProdu.Location = new Point(123, 33);
            nomeProdu.Name = "nomeProdu";
            nomeProdu.Size = new Size(248, 23);
            nomeProdu.TabIndex = 0;
            // 
            // marcaProd
            // 
            marcaProd.Location = new Point(123, 60);
            marcaProd.Name = "marcaProd";
            marcaProd.Size = new Size(248, 23);
            marcaProd.TabIndex = 1;
            // 
            // quantidadeProd
            // 
            quantidadeProd.Location = new Point(123, 89);
            quantidadeProd.Name = "quantidadeProd";
            quantidadeProd.Size = new Size(248, 23);
            quantidadeProd.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 36);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 92);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 5;
            label2.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 63);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 6;
            label3.Text = "Marca do Produto";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dataProd);
            groupBox1.Controls.Add(quantidadeProd);
            groupBox1.Controls.Add(nomeProdu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(marcaProd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 157);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar Produtos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 124);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 8;
            label4.Text = "Data de Entrada";
            // 
            // dataProd
            // 
            dataProd.Location = new Point(123, 118);
            dataProd.Name = "dataProd";
            dataProd.Size = new Size(248, 23);
            dataProd.TabIndex = 7;
            // 
            // btnCadas
            // 
            btnCadas.Location = new Point(146, 175);
            btnCadas.Name = "btnCadas";
            btnCadas.Size = new Size(75, 23);
            btnCadas.TabIndex = 9;
            btnCadas.Text = "Inserir";
            btnCadas.UseVisualStyleBackColor = true;
            btnCadas.Click += btnCadas_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(238, 175);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 10;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 220);
            Controls.Add(btnlimpar);
            Controls.Add(btnCadas);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Cadastrar Produtos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox nomeProdu;
        private TextBox marcaProd;
        private TextBox quantidadeProd;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnCadas;
        private Button btnlimpar;
        private Label label4;
        private DateTimePicker dataProd;
    }
}
