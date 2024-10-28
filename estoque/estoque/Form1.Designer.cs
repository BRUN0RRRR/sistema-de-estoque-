namespace estoque
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
            inventario = new DataGridView();
            menuStrip1 = new MenuStrip();
            modulosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            deletarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            consumo = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            panelinventario = new Panel();
            panelconsumo = new Panel();
            btnatual = new Button();
            ((System.ComponentModel.ISupportInitialize)inventario).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)consumo).BeginInit();
            panelinventario.SuspendLayout();
            panelconsumo.SuspendLayout();
            SuspendLayout();
            // 
            // inventario
            // 
            inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventario.Location = new Point(6, 35);
            inventario.Name = "inventario";
            inventario.Size = new Size(582, 236);
            inventario.TabIndex = 0;
            inventario.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { modulosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(655, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // modulosToolStripMenuItem
            // 
            modulosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, deletarToolStripMenuItem, editarToolStripMenuItem });
            modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            modulosToolStripMenuItem.Size = new Size(66, 20);
            modulosToolStripMenuItem.Text = "Módulos";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(124, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // deletarToolStripMenuItem
            // 
            deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            deletarToolStripMenuItem.Size = new Size(124, 22);
            deletarToolStripMenuItem.Text = "Baixar";
            deletarToolStripMenuItem.Click += deletarToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(124, 22);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // consumo
            // 
            consumo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            consumo.Location = new Point(6, 28);
            consumo.Name = "consumo";
            consumo.Size = new Size(582, 236);
            consumo.TabIndex = 2;
            consumo.CellContentClick += consumo_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 2);
            label1.Name = "label1";
            label1.Size = new Size(215, 30);
            label1.TabIndex = 3;
            label1.Text = "Inventário de Produto";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(56, 0);
            label2.Name = "label2";
            label2.Size = new Size(210, 30);
            label2.TabIndex = 4;
            label2.Text = "Consumo de Estoque";
            label2.Click += label2_Click;
            // 
            // panelinventario
            // 
            panelinventario.Controls.Add(inventario);
            panelinventario.Controls.Add(label1);
            panelinventario.Location = new Point(12, 59);
            panelinventario.Name = "panelinventario";
            panelinventario.Size = new Size(615, 274);
            panelinventario.TabIndex = 5;
            // 
            // panelconsumo
            // 
            panelconsumo.Controls.Add(consumo);
            panelconsumo.Controls.Add(label2);
            panelconsumo.Location = new Point(12, 362);
            panelconsumo.Name = "panelconsumo";
            panelconsumo.Size = new Size(615, 274);
            panelconsumo.TabIndex = 6;
            // 
            // btnatual
            // 
            btnatual.Location = new Point(525, 27);
            btnatual.Name = "btnatual";
            btnatual.Size = new Size(75, 23);
            btnatual.TabIndex = 7;
            btnatual.Text = "Atualizar";
            btnatual.UseVisualStyleBackColor = true;
            btnatual.Click += btnatual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 656);
            Controls.Add(btnatual);
            Controls.Add(panelconsumo);
            Controls.Add(panelinventario);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Estoque";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)inventario).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)consumo).EndInit();
            panelinventario.ResumeLayout(false);
            panelinventario.PerformLayout();
            panelconsumo.ResumeLayout(false);
            panelconsumo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView inventario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem modulosToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem deletarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private DataGridView consumo;
        private Label label1;
        private Label label2;
        private Panel panelinventario;
        private Panel panelconsumo;
        private Button btnatual;
    }
}
