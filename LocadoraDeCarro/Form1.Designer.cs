namespace LocadoraDeCarro
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
            Consulta = new TabControl();
            tabPageAluga = new TabPage();
            textBoxDias = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonAlugar = new Button();
            textBoxQuantidade = new TextBox();
            textBoxTipo = new TextBox();
            textBoxMarca = new TextBox();
            textBoxNome = new TextBox();
            tabPageConsulta = new TabPage();
            label7 = new Label();
            dataGridViewConsulta = new DataGridView();
            buttonConsultar = new Button();
            textBoxConsulta = new TextBox();
            Consulta.SuspendLayout();
            tabPageAluga.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).BeginInit();
            SuspendLayout();
            // 
            // Consulta
            // 
            Consulta.Controls.Add(tabPageAluga);
            Consulta.Controls.Add(tabPageConsulta);
            Consulta.Location = new Point(12, 12);
            Consulta.Name = "Consulta";
            Consulta.SelectedIndex = 0;
            Consulta.Size = new Size(776, 426);
            Consulta.TabIndex = 0;
            // 
            // tabPageAluga
            // 
            tabPageAluga.Controls.Add(textBoxDias);
            tabPageAluga.Controls.Add(label6);
            tabPageAluga.Controls.Add(label5);
            tabPageAluga.Controls.Add(label4);
            tabPageAluga.Controls.Add(label3);
            tabPageAluga.Controls.Add(label2);
            tabPageAluga.Controls.Add(label1);
            tabPageAluga.Controls.Add(buttonAlugar);
            tabPageAluga.Controls.Add(textBoxQuantidade);
            tabPageAluga.Controls.Add(textBoxTipo);
            tabPageAluga.Controls.Add(textBoxMarca);
            tabPageAluga.Controls.Add(textBoxNome);
            tabPageAluga.Location = new Point(4, 34);
            tabPageAluga.Name = "tabPageAluga";
            tabPageAluga.Padding = new Padding(3);
            tabPageAluga.Size = new Size(768, 388);
            tabPageAluga.TabIndex = 0;
            tabPageAluga.Text = "Alugar";
            tabPageAluga.UseVisualStyleBackColor = true;
            // 
            // textBoxDias
            // 
            textBoxDias.Location = new Point(493, 241);
            textBoxDias.Name = "textBoxDias";
            textBoxDias.Size = new Size(150, 31);
            textBoxDias.TabIndex = 11;
            textBoxDias.KeyPress += textBoxDias_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 244);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 10;
            label6.Text = "Duração/Dias:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 244);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 9;
            label5.Text = "Quantidade: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 198);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 8;
            label4.Text = "Tipo: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 145);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 7;
            label3.Text = "Marca: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 95);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 6;
            label2.Text = "Nome do carro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(331, 48);
            label1.TabIndex = 5;
            label1.Text = "Aluguel de Veículos";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonAlugar
            // 
            buttonAlugar.Location = new Point(308, 308);
            buttonAlugar.Name = "buttonAlugar";
            buttonAlugar.Size = new Size(158, 52);
            buttonAlugar.TabIndex = 4;
            buttonAlugar.Text = "Alugar";
            buttonAlugar.UseVisualStyleBackColor = true;
            buttonAlugar.Click += buttonAlugar_Click;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(159, 241);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(139, 31);
            textBoxQuantidade.TabIndex = 3;
            textBoxQuantidade.KeyPress += textBoxQuantidade_KeyPress;
            // 
            // textBoxTipo
            // 
            textBoxTipo.Location = new Point(159, 195);
            textBoxTipo.Name = "textBoxTipo";
            textBoxTipo.Size = new Size(433, 31);
            textBoxTipo.TabIndex = 2;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(159, 142);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(433, 31);
            textBoxMarca.TabIndex = 1;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(159, 92);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(433, 31);
            textBoxNome.TabIndex = 0;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(label7);
            tabPageConsulta.Controls.Add(dataGridViewConsulta);
            tabPageConsulta.Controls.Add(buttonConsultar);
            tabPageConsulta.Controls.Add(textBoxConsulta);
            tabPageConsulta.Location = new Point(4, 34);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(768, 388);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 45);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 3;
            label7.Text = "Consulta: ";
            // 
            // dataGridViewConsulta
            // 
            dataGridViewConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsulta.Location = new Point(48, 130);
            dataGridViewConsulta.Name = "dataGridViewConsulta";
            dataGridViewConsulta.RowHeadersWidth = 62;
            dataGridViewConsulta.Size = new Size(514, 252);
            dataGridViewConsulta.TabIndex = 2;
            // 
            // buttonConsultar
            // 
            buttonConsultar.Location = new Point(431, 37);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(112, 41);
            buttonConsultar.TabIndex = 1;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // textBoxConsulta
            // 
            textBoxConsulta.Location = new Point(116, 42);
            textBoxConsulta.Name = "textBoxConsulta";
            textBoxConsulta.Size = new Size(278, 31);
            textBoxConsulta.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Consulta);
            MaximumSize = new Size(822, 506);
            MinimumSize = new Size(822, 506);
            Name = "Form1";
            Text = "Form1";
            Consulta.ResumeLayout(false);
            tabPageAluga.ResumeLayout(false);
            tabPageAluga.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Consulta;
        private TabPage tabPageAluga;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonAlugar;
        private TextBox textBoxQuantidade;
        private TextBox textBoxTipo;
        private TextBox textBoxMarca;
        private TextBox textBoxNome;
        private TabPage tabPageConsulta;
        private Label label5;
        private TextBox textBoxDias;
        private Label label6;
        private Label label7;
        private DataGridView dataGridViewConsulta;
        private Button buttonConsultar;
        private TextBox textBoxConsulta;
    }
}
