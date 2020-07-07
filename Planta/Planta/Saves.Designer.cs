namespace Planta
{
    partial class Saves
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
            this.dataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_nivel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_novo_jogo = new System.Windows.Forms.Button();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRepeater1.BackColor = System.Drawing.Color.DarkOliveGreen;
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.BackColor = System.Drawing.Color.Honeydew;
            this.dataRepeater1.ItemTemplate.Controls.Add(this.btn_excluir);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.btn_selecionar);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lbl_hp);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.label6);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lbl_nivel);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.label4);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.lbl_status);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.label1);
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(550, 121);
            this.dataRepeater1.Location = new System.Drawing.Point(12, 74);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Size = new System.Drawing.Size(558, 543);
            this.dataRepeater1.TabIndex = 0;
            this.dataRepeater1.Text = "dataRepeater1";
            this.dataRepeater1.CurrentItemIndexChanged += new System.EventHandler(this.dataRepeater1_CurrentItemIndexChanged);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_excluir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_excluir.FlatAppearance.BorderSize = 5;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(319, 58);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(144, 43);
            this.btn_excluir.TabIndex = 7;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_selecionar.BackColor = System.Drawing.Color.Indigo;
            this.btn_selecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selecionar.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btn_selecionar.FlatAppearance.BorderSize = 5;
            this.btn_selecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selecionar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btn_selecionar.ForeColor = System.Drawing.Color.White;
            this.btn_selecionar.Location = new System.Drawing.Point(319, 9);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(185, 43);
            this.btn_selecionar.TabIndex = 6;
            this.btn_selecionar.Text = "SELECIONAR";
            this.btn_selecionar.UseVisualStyleBackColor = false;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // lbl_hp
            // 
            this.lbl_hp.AutoSize = true;
            this.lbl_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hp.Location = new System.Drawing.Point(109, 67);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(79, 29);
            this.lbl_hp.TabIndex = 5;
            this.lbl_hp.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "HP:";
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel.Location = new System.Drawing.Point(109, 38);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(79, 29);
            this.lbl_nivel.TabIndex = 3;
            this.lbl_nivel.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estágio:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(109, 9);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(79, 29);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // btn_novo_jogo
            // 
            this.btn_novo_jogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_novo_jogo.BackColor = System.Drawing.Color.Indigo;
            this.btn_novo_jogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo_jogo.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btn_novo_jogo.FlatAppearance.BorderSize = 5;
            this.btn_novo_jogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo_jogo.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btn_novo_jogo.ForeColor = System.Drawing.Color.White;
            this.btn_novo_jogo.Location = new System.Drawing.Point(16, 12);
            this.btn_novo_jogo.Name = "btn_novo_jogo";
            this.btn_novo_jogo.Size = new System.Drawing.Size(554, 52);
            this.btn_novo_jogo.TabIndex = 7;
            this.btn_novo_jogo.Text = "Novo Jogo";
            this.btn_novo_jogo.UseVisualStyleBackColor = false;
            this.btn_novo_jogo.Click += new System.EventHandler(this.btn_novo_jogo_Click);
            // 
            // Saves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(582, 629);
            this.Controls.Add(this.btn_novo_jogo);
            this.Controls.Add(this.dataRepeater1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Saves";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Saves_Load);
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.PerformLayout();
            this.dataRepeater1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_hp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_nivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.Button btn_novo_jogo;
        private System.Windows.Forms.Button btn_excluir;
    }
}