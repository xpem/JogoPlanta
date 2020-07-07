namespace Planta
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_situacaohp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_situacao_sede = new System.Windows.Forms.Label();
            this.btnAguar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.btnmeiaagua = new System.Windows.Forms.Button();
            this.btnjanela = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_pontos = new System.Windows.Forms.Label();
            this.lbl_SituacaoLuz = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_solo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_loja = new System.Windows.Forms.Button();
            this.tb_ctrl = new System.Windows.Forms.TabControl();
            this.tbpg_menu = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_nome_loja = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_antiacaro = new System.Windows.Forms.Button();
            this.btn_neen = new System.Windows.Forms.Button();
            this.btn_fertilizante = new System.Windows.Forms.Button();
            this.picboxplanta = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tb_ctrl.SuspendLayout();
            this.tbpg_menu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxplanta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            // 
            // lbl_situacaohp
            // 
            this.lbl_situacaohp.AutoSize = true;
            this.lbl_situacaohp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_situacaohp.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_situacaohp.ForeColor = System.Drawing.Color.Red;
            this.lbl_situacaohp.Location = new System.Drawing.Point(95, 14);
            this.lbl_situacaohp.Name = "lbl_situacaohp";
            this.lbl_situacaohp.Size = new System.Drawing.Size(144, 25);
            this.lbl_situacaohp.TabIndex = 2;
            this.lbl_situacaohp.Text = "carregando....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Umidade:";
            // 
            // lbl_situacao_sede
            // 
            this.lbl_situacao_sede.AutoSize = true;
            this.lbl_situacao_sede.BackColor = System.Drawing.Color.Transparent;
            this.lbl_situacao_sede.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_situacao_sede.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_situacao_sede.Location = new System.Drawing.Point(97, 51);
            this.lbl_situacao_sede.Name = "lbl_situacao_sede";
            this.lbl_situacao_sede.Size = new System.Drawing.Size(17, 17);
            this.lbl_situacao_sede.TabIndex = 4;
            this.lbl_situacao_sede.Text = "0";
            // 
            // btnAguar
            // 
            this.btnAguar.BackColor = System.Drawing.Color.Indigo;
            this.btnAguar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAguar.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnAguar.FlatAppearance.BorderSize = 5;
            this.btnAguar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAguar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnAguar.ForeColor = System.Drawing.Color.White;
            this.btnAguar.Location = new System.Drawing.Point(6, 6);
            this.btnAguar.Name = "btnAguar";
            this.btnAguar.Size = new System.Drawing.Size(169, 54);
            this.btnAguar.TabIndex = 5;
            this.btnAguar.Text = "Agua 1/1(2)";
            this.btnAguar.UseVisualStyleBackColor = false;
            this.btnAguar.Click += new System.EventHandler(this.btnAguar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hp:";
            // 
            // lbl_hp
            // 
            this.lbl_hp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hp.AutoSize = true;
            this.lbl_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbl_hp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_hp.Location = new System.Drawing.Point(97, 134);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(17, 17);
            this.lbl_hp.TabIndex = 7;
            this.lbl_hp.Text = "0";
            // 
            // btnmeiaagua
            // 
            this.btnmeiaagua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnmeiaagua.BackColor = System.Drawing.Color.Indigo;
            this.btnmeiaagua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmeiaagua.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnmeiaagua.FlatAppearance.BorderSize = 5;
            this.btnmeiaagua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmeiaagua.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnmeiaagua.ForeColor = System.Drawing.Color.White;
            this.btnmeiaagua.Location = new System.Drawing.Point(181, 6);
            this.btnmeiaagua.Name = "btnmeiaagua";
            this.btnmeiaagua.Size = new System.Drawing.Size(169, 54);
            this.btnmeiaagua.TabIndex = 8;
            this.btnmeiaagua.Text = "Agua 1/2(1)";
            this.btnmeiaagua.UseVisualStyleBackColor = false;
            this.btnmeiaagua.Click += new System.EventHandler(this.btnmeiaagua_Click);
            // 
            // btnjanela
            // 
            this.btnjanela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnjanela.BackColor = System.Drawing.Color.Indigo;
            this.btnjanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnjanela.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnjanela.FlatAppearance.BorderSize = 5;
            this.btnjanela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnjanela.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjanela.ForeColor = System.Drawing.Color.White;
            this.btnjanela.Location = new System.Drawing.Point(6, 66);
            this.btnjanela.Name = "btnjanela";
            this.btnjanela.Size = new System.Drawing.Size(344, 54);
            this.btnjanela.TabIndex = 9;
            this.btnjanela.Text = "COLOCAR NA JANELA";
            this.btnjanela.UseVisualStyleBackColor = false;
            this.btnjanela.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pontos:";
            // 
            // lbl_pontos
            // 
            this.lbl_pontos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pontos.AutoSize = true;
            this.lbl_pontos.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pontos.Location = new System.Drawing.Point(313, 48);
            this.lbl_pontos.Name = "lbl_pontos";
            this.lbl_pontos.Size = new System.Drawing.Size(21, 21);
            this.lbl_pontos.TabIndex = 11;
            this.lbl_pontos.Text = "0";
            // 
            // lbl_SituacaoLuz
            // 
            this.lbl_SituacaoLuz.AutoSize = true;
            this.lbl_SituacaoLuz.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SituacaoLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SituacaoLuz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_SituacaoLuz.Location = new System.Drawing.Point(97, 78);
            this.lbl_SituacaoLuz.Name = "lbl_SituacaoLuz";
            this.lbl_SituacaoLuz.Size = new System.Drawing.Size(17, 17);
            this.lbl_SituacaoLuz.TabIndex = 13;
            this.lbl_SituacaoLuz.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Luz solar:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.lbl_solo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_hp);
            this.panel1.Controls.Add(this.lbl_SituacaoLuz);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_situacaohp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_pontos);
            this.panel1.Controls.Add(this.lbl_situacao_sede);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(346, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 169);
            this.panel1.TabIndex = 14;
            // 
            // lbl_solo
            // 
            this.lbl_solo.AutoSize = true;
            this.lbl_solo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_solo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_solo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_solo.Location = new System.Drawing.Point(97, 106);
            this.lbl_solo.Name = "lbl_solo";
            this.lbl_solo.Size = new System.Drawing.Size(17, 17);
            this.lbl_solo.TabIndex = 15;
            this.lbl_solo.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Solo:";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btn_sair.FlatAppearance.BorderSize = 5;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(583, 133);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(169, 54);
            this.btn_sair.TabIndex = 15;
            this.btn_sair.Text = "SALVAR E SAIR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_loja
            // 
            this.btn_loja.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_loja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loja.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.btn_loja.FlatAppearance.BorderSize = 5;
            this.btn_loja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loja.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btn_loja.ForeColor = System.Drawing.Color.White;
            this.btn_loja.Location = new System.Drawing.Point(356, 6);
            this.btn_loja.Name = "btn_loja";
            this.btn_loja.Size = new System.Drawing.Size(169, 54);
            this.btn_loja.TabIndex = 16;
            this.btn_loja.Text = "LOJA";
            this.btn_loja.UseVisualStyleBackColor = false;
            this.btn_loja.Click += new System.EventHandler(this.btn_loja_Click);
            // 
            // tb_ctrl
            // 
            this.tb_ctrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ctrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tb_ctrl.Controls.Add(this.tbpg_menu);
            this.tb_ctrl.Controls.Add(this.tabPage2);
            this.tb_ctrl.ItemSize = new System.Drawing.Size(0, 1);
            this.tb_ctrl.Location = new System.Drawing.Point(12, 347);
            this.tb_ctrl.Name = "tb_ctrl";
            this.tb_ctrl.Padding = new System.Drawing.Point(0, 0);
            this.tb_ctrl.SelectedIndex = 0;
            this.tb_ctrl.Size = new System.Drawing.Size(766, 211);
            this.tb_ctrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tb_ctrl.TabIndex = 17;
            // 
            // tbpg_menu
            // 
            this.tbpg_menu.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.tbpg_menu.Controls.Add(this.btnAguar);
            this.tbpg_menu.Controls.Add(this.btn_sair);
            this.tbpg_menu.Controls.Add(this.btn_loja);
            this.tbpg_menu.Controls.Add(this.btnmeiaagua);
            this.tbpg_menu.Controls.Add(this.btnjanela);
            this.tbpg_menu.Location = new System.Drawing.Point(4, 5);
            this.tbpg_menu.Name = "tbpg_menu";
            this.tbpg_menu.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_menu.Size = new System.Drawing.Size(758, 202);
            this.tbpg_menu.TabIndex = 0;
            this.tbpg_menu.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.tabPage2.Controls.Add(this.lbl_nome_loja);
            this.tabPage2.Controls.Add(this.btn_voltar);
            this.tabPage2.Controls.Add(this.btn_antiacaro);
            this.tabPage2.Controls.Add(this.btn_neen);
            this.tabPage2.Controls.Add(this.btn_fertilizante);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(758, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // lbl_nome_loja
            // 
            this.lbl_nome_loja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nome_loja.AutoSize = true;
            this.lbl_nome_loja.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_loja.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_nome_loja.Location = new System.Drawing.Point(6, 3);
            this.lbl_nome_loja.Name = "lbl_nome_loja";
            this.lbl_nome_loja.Size = new System.Drawing.Size(67, 30);
            this.lbl_nome_loja.TabIndex = 19;
            this.lbl_nome_loja.Text = "LOJA";
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btn_voltar.FlatAppearance.BorderSize = 5;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(623, 147);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(129, 40);
            this.btn_voltar.TabIndex = 17;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_antiacaro
            // 
            this.btn_antiacaro.AccessibleDescription = "Cura Ácaros";
            this.btn_antiacaro.BackColor = System.Drawing.Color.Indigo;
            this.btn_antiacaro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_antiacaro.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btn_antiacaro.FlatAppearance.BorderSize = 5;
            this.btn_antiacaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_antiacaro.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btn_antiacaro.ForeColor = System.Drawing.Color.White;
            this.btn_antiacaro.Location = new System.Drawing.Point(243, 36);
            this.btn_antiacaro.Name = "btn_antiacaro";
            this.btn_antiacaro.Size = new System.Drawing.Size(231, 54);
            this.btn_antiacaro.TabIndex = 8;
            this.btn_antiacaro.Text = "ANTIÁCARO(3)";
            this.btn_antiacaro.UseVisualStyleBackColor = false;
            this.btn_antiacaro.Click += new System.EventHandler(this.btn_antiacaro_Click);
            // 
            // btn_neen
            // 
            this.btn_neen.AccessibleDescription = "Cura Pulgões e Conchinilhas";
            this.btn_neen.BackColor = System.Drawing.Color.Indigo;
            this.btn_neen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_neen.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btn_neen.FlatAppearance.BorderSize = 5;
            this.btn_neen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_neen.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btn_neen.ForeColor = System.Drawing.Color.White;
            this.btn_neen.Location = new System.Drawing.Point(6, 36);
            this.btn_neen.Name = "btn_neen";
            this.btn_neen.Size = new System.Drawing.Size(231, 54);
            this.btn_neen.TabIndex = 7;
            this.btn_neen.Text = "ÓLEO(5)";
            this.btn_neen.UseVisualStyleBackColor = false;
            this.btn_neen.Click += new System.EventHandler(this.btn_neen_Click);
            // 
            // btn_fertilizante
            // 
            this.btn_fertilizante.AccessibleDescription = "Restabelece a qualidade do solo";
            this.btn_fertilizante.BackColor = System.Drawing.Color.Indigo;
            this.btn_fertilizante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fertilizante.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btn_fertilizante.FlatAppearance.BorderSize = 5;
            this.btn_fertilizante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fertilizante.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btn_fertilizante.ForeColor = System.Drawing.Color.White;
            this.btn_fertilizante.Location = new System.Drawing.Point(480, 36);
            this.btn_fertilizante.Name = "btn_fertilizante";
            this.btn_fertilizante.Size = new System.Drawing.Size(231, 54);
            this.btn_fertilizante.TabIndex = 6;
            this.btn_fertilizante.Text = "FERTILIZANTE(10)";
            this.btn_fertilizante.UseVisualStyleBackColor = false;
            this.btn_fertilizante.Click += new System.EventHandler(this.btn_fertilizante_Click);
            // 
            // picboxplanta
            // 
            this.picboxplanta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxplanta.InitialImage = null;
            this.picboxplanta.Location = new System.Drawing.Point(12, 12);
            this.picboxplanta.Name = "picboxplanta";
            this.picboxplanta.Size = new System.Drawing.Size(328, 329);
            this.picboxplanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxplanta.TabIndex = 0;
            this.picboxplanta.TabStop = false;
            this.picboxplanta.Click += new System.EventHandler(this.picboxplanta_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(787, 624);
            this.Controls.Add(this.tb_ctrl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picboxplanta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tb_ctrl.ResumeLayout(false);
            this.tbpg_menu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxplanta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxplanta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_situacaohp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_situacao_sede;
        private System.Windows.Forms.Button btnAguar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_hp;
        private System.Windows.Forms.Button btnmeiaagua;
        private System.Windows.Forms.Button btnjanela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_pontos;
        private System.Windows.Forms.Label lbl_SituacaoLuz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_loja;
        private System.Windows.Forms.TabControl tb_ctrl;
        private System.Windows.Forms.TabPage tbpg_menu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_antiacaro;
        private System.Windows.Forms.Button btn_neen;
        private System.Windows.Forms.Button btn_fertilizante;
        private System.Windows.Forms.Label lbl_solo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_nome_loja;
    }
}

