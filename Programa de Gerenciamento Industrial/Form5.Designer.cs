﻿namespace Programa_de_Gerenciamento_Industrial
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(242, 21);
            label1.TabIndex = 0;
            label1.Text = "ID (Gerado automaticamente):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(166, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome (Obrigatório):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(214, 21);
            label3.TabIndex = 2;
            label3.Text = "CPF ou CNPJ (Obrigatório):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(185, 21);
            label4.TabIndex = 3;
            label4.Text = "Telefone (Obrigatório):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 244);
            label5.Name = "label5";
            label5.Size = new Size(170, 21);
            label5.TabIndex = 4;
            label5.Text = "Endereço (Opcional):";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(260, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(260, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(260, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(260, 199);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(212, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(260, 244);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(212, 23);
            textBox5.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(400, 333);
            button1.Name = "button1";
            button1.Size = new Size(106, 29);
            button1.TabIndex = 11;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.OrangeRed;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(34, 333);
            button5.Name = "button5";
            button5.Size = new Size(106, 29);
            button5.TabIndex = 10;
            button5.Text = "Sair";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Tela_Login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(550, 400);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button5;
    }
}