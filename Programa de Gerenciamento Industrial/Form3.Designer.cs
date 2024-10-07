namespace Programa_de_Gerenciamento_Industrial
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
            dataGridViewLotes = new DataGridView();
            idLote = new DataGridViewTextBoxColumn();
            conteudo = new DataGridViewTextBoxColumn();
            dataCriacao = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLotes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLotes
            // 
            dataGridViewLotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLotes.BackgroundColor = SystemColors.Control;
            dataGridViewLotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLotes.Columns.AddRange(new DataGridViewColumn[] { idLote, conteudo, dataCriacao, status });
            dataGridViewLotes.Location = new Point(17, 68);
            dataGridViewLotes.Name = "dataGridViewLotes";
            dataGridViewLotes.RowTemplate.Height = 25;
            dataGridViewLotes.Size = new Size(516, 431);
            dataGridViewLotes.TabIndex = 0;
            dataGridViewLotes.CellContentClick += dataGridViewLotes_CellContentClick;
            // 
            // idLote
            // 
            idLote.HeaderText = "idLote";
            idLote.Name = "idLote";
            // 
            // conteudo
            // 
            conteudo.HeaderText = "conteudo";
            conteudo.Name = "conteudo";
            // 
            // dataCriacao
            // 
            dataCriacao.HeaderText = "dataCriacao";
            dataCriacao.Name = "dataCriacao";
            // 
            // status
            // 
            status.HeaderText = "status";
            status.Name = "status";
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(569, 120);
            button1.Name = "button1";
            button1.Size = new Size(106, 29);
            button1.TabIndex = 1;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(569, 191);
            button2.Name = "button2";
            button2.Size = new Size(106, 29);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(569, 262);
            button3.Name = "button3";
            button3.Size = new Size(106, 29);
            button3.TabIndex = 3;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.OrangeRed;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(569, 334);
            button4.Name = "button4";
            button4.Size = new Size(106, 29);
            button4.TabIndex = 4;
            button4.Text = "Atualizar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.OrangeRed;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(569, 408);
            button5.Name = "button5";
            button5.Size = new Size(106, 29);
            button5.TabIndex = 5;
            button5.Text = "Sair";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Tela_Login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(731, 515);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridViewLotes);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLotes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewLotes;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn idLote;
        private DataGridViewTextBoxColumn conteudo;
        private DataGridViewTextBoxColumn dataCriacao;
        private DataGridViewTextBoxColumn status;
    }
}