namespace Planta
{
    partial class Login
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
            this.btnjanela = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnjanela
            // 
            this.btnjanela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnjanela.BackColor = System.Drawing.Color.Brown;
            this.btnjanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnjanela.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnjanela.FlatAppearance.BorderSize = 5;
            this.btnjanela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnjanela.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjanela.ForeColor = System.Drawing.Color.White;
            this.btnjanela.Location = new System.Drawing.Point(9, 12);
            this.btnjanela.Name = "btnjanela";
            this.btnjanela.Size = new System.Drawing.Size(399, 53);
            this.btnjanela.TabIndex = 10;
            this.btnjanela.Text = "NOVO JOGO";
            this.btnjanela.UseVisualStyleBackColor = false;
            this.btnjanela.Click += new System.EventHandler(this.btnjanela_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(399, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "CONTINUAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnjanela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnjanela;
        private System.Windows.Forms.Button button1;
    }
}