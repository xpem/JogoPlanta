using ML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planta
{
    public partial class Home : Form
    {

        private ML.Dados dados { get; set; }
        private int BaseChanceEventualidade { get; set; }

        public Home(Dados dadosrep)
        {

            dados = dadosrep;
            Task.Run(() => Ciclo());
            InitializeComponent();
        }

        private async Task Ciclo()
        {
            int CiclosAutoSave = 0;
            BaseChanceEventualidade = 0;

            while (!dados.Morta)
            {
                System.Threading.Thread.Sleep(3000);
                BaseChanceEventualidade = 5;
                //a sede aumenta a cada cilo
                dados.Sede = dados.Sede + 1;

                //caso a planta esteja 100%, ela ganha um ponto de crescimento a maise se torna mais resistente
                if (dados.Hp > dados.HpMax)
                    dados.HpMax = dados.HpMax + 1;

                //contagem da pontuação
                if (dados.Hp > dados.BasePontos + 15)
                {
                    dados.BasePontos += 15;
                    dados.Pontos += 1;
                }

                //ajuda na obtenção de pontos apos um descuido com o hp
                if(dados.Hp < dados.BasePontos-15)
                {
                    dados.BasePontos -= 1;
                }

                //verifica sede impacta no hp
                VerificaSede();

                //hp é impactado aqui também 
                VerificaSituacao();


                VerificaPosicao();

                VerificaLuz();

                //campo não será visível
                lbl_hp.Invoke(new Action(() => lbl_hp.Text = dados.Hp.ToString()));

                VerificaImagem();

                VerificaDanosEventualidades();


                VerificaSolo();

                AtualizaPontos();

                if (CiclosAutoSave == 5)
                {
                    // 1 - pulgões 2 - ácaros 3 - conchonilhas
                    BL.SqLiteLogin.UptSave(dados);
                    //verificações de eventualidades
                    CiclosAutoSave = 0;

                }
                else CiclosAutoSave += 1;


                if (dados.CiclosEventualidade == 15)
                {
                    dados.Pulgoes = BL.Verificacoes.VerificaEventualidade(1, BaseChanceEventualidade);
                    dados.Acaros = BL.Verificacoes.VerificaEventualidade(2, BaseChanceEventualidade);
                    //dados.Conchonilhas = BL.Verificacoes.VerificaEventualidade(3, BaseChanceEventualidade);
                    dados.CiclosEventualidade = 0;
                }
                else dados.CiclosEventualidade += 1;

                //intervalo entre florescimentos
                if((dados.CicloFlorescimento >= 15))
                {
                    dados.CicloFlorescimento += 1;
                    dados.Florescida = true;
                }
                if(dados.CicloFlorescimento == 50)
                {
                   
                    dados.CicloFlorescimento = 0;
                }

            }

            if (dados.Morta)
            {
                MessageBox.Show("Sua plantinha morreu.");
            }
        }


        private async Task VerificaPosicao()
        {

            if (dados.PegandoSol)
            {
                dados.HorasNoSol += 1;
                dados.Sede += 1;
                dados.HorasNoSolConsecutivas += 1;
                if (dados.HorasNoSolConsecutivas < 4)
                {
                    dados.Hp += 2;
                }
                if (dados.HorasNoSolConsecutivas == 4)
                {
                    dados.Hp += 1;
                    dados.Pontos += 1;
                }
            }
            if (!dados.PegandoSol)
            {
                dados.HorasNoSol -= 1;
                dados.HorasNoSolConsecutivas = 0;
            }
        }

        private async Task VerificaLuz()
        {
            if (dados.HorasNoSol > 7)
            {
                dados.Sede += 5;
                dados.Hp -= 1;
                dados.Solo -= 2;
                dados.HorasNoSolConsecutivas = 0;
                lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.Text = "Queimanda!"));
                lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.ForeColor = Color.Red));
            }
            else if (dados.HorasNoSol > 5)
            {
                dados.Sede += 3;
                dados.Solo -= 1;
                dados.HorasNoSolConsecutivas = 0;
                lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.Text = "Desidratada!"));
                lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.ForeColor = Color.Gold));
            }
            else if (dados.HorasNoSol <= 5 && dados.HorasNoSol >= -5)
            {
                if (!dados.PegandoSol)
                {
                    lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.Text = "Normal"));
                    lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.ForeColor = Color.Green));
                }
                else
                {
                    lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.Text = "Precisa de sombra!"));
                    lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.ForeColor = Color.Gold));
                }
            }
            else if (dados.HorasNoSol <= -40)
            {
                lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.Text = "Murcha!"));
                lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.ForeColor = Color.Red));
                dados.Hp -= 1;
            }
            else if (dados.HorasNoSol <= -20)
            {
                if (dados.PegandoSol)
                {
                    lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.Text = "Normal"));
                    lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.ForeColor = Color.Green));
                }
                else
                {
                    lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.Text = "Precisa de sol!"));
                    lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.ForeColor = Color.Gold));
                }
            }
            else if (dados.HorasNoSol <= -5)
            {
                lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.Text = "Normal"));
                lbl_SituacaoLuz.Invoke(new Action(() => lbl_SituacaoLuz.ForeColor = Color.Green));
            }

        }

        private async Task VerificaSede()
        {

            if (dados.SemSedeConsecutivas == 10)
            {
                dados.Pontos += 1;
                dados.SemSedeConsecutivas = 0;
            }

            if (dados.Sede < 0)
            {
                lbl_situacao_sede.Invoke(new Action(() => lbl_situacao_sede.Text = "Úmida demais"));
                lbl_situacao_sede.Invoke(new Action(() => lbl_situacao_sede.ForeColor = Color.DarkRed));
                dados.Hp = dados.Hp - 3;
                dados.SemSedeConsecutivas = 0;
            }
            else if (dados.Sede < 35)
            {
                lbl_situacao_sede.Invoke(new Action(() => lbl_situacao_sede.Text = "Normal"));
                lbl_situacao_sede.Invoke(new Action(() => lbl_situacao_sede.ForeColor = Color.Green));
                dados.Hp = dados.Hp + 1;
                dados.SemSedeConsecutivas += 1;
            }
            else if (dados.Sede < 45)
            {
                lbl_situacao_sede.Invoke(new Action(() => lbl_situacao_sede.Text = "Com sede"));
                lbl_situacao_sede.Invoke(new Action(() => lbl_situacao_sede.ForeColor = Color.Gold));
            }
            else if (dados.Sede < 55)
            {
                lbl_situacao_sede.Invoke(new Action(() => lbl_situacao_sede.Text = "Ressecada"));
                lbl_situacao_sede.Invoke(new Action(() => lbl_situacao_sede.ForeColor = Color.DarkRed));
                dados.Hp = dados.Hp - 1;
                dados.Solo -= 1;

                dados.SemSedeConsecutivas = 0;
            }
            if (dados.Sede > 55)
            {
                lbl_situacao_sede.Invoke(new Action(() => lbl_situacao_sede.Text = "Seca"));
                lbl_situacao_sede.Invoke(new Action(() => lbl_situacao_sede.ForeColor = Color.DarkRed));
                dados.Hp = dados.Hp - 3;
                dados.Solo -= 2;
                dados.SemSedeConsecutivas = 0;
            }
        }

        public async Task AtualizaPontos()
        {
            lbl_pontos.Invoke(new Action(() => lbl_pontos.Text = dados.Pontos.ToString()));
        }

        public async Task VerificaImagem()
        {
            if (dados.HpMax < 150)
            {
                if (dados.Morrendo)
                {
                    if (this.picboxplanta.Image != global::Planta.Properties.Resources.bebe_morrendo)
                        this.picboxplanta.Image = global::Planta.Properties.Resources.bebe_morrendo;
                }
                if (dados.Seca)
                {
                    if (this.picboxplanta.Image != global::Planta.Properties.Resources.bebe_seco)
                        this.picboxplanta.Image = global::Planta.Properties.Resources.bebe_seco;
                }
                else if (this.picboxplanta.Image != global::Planta.Properties.Resources.bebe)
                    this.picboxplanta.Image = global::Planta.Properties.Resources.bebe;
                dados.EstagioCrescimento = 1;
            }
            else if (dados.HpMax < 200)
            {
                if (dados.Morrendo)
                {
                    if (this.picboxplanta.Image != global::Planta.Properties.Resources.crianca_morrendo)
                        this.picboxplanta.Image = global::Planta.Properties.Resources.crianca_morrendo;
                }
                else if (dados.Seca)
                {
                    if (this.picboxplanta.Image != global::Planta.Properties.Resources.crianca_seca)
                        this.picboxplanta.Image = global::Planta.Properties.Resources.crianca_seca;
                }
                else if (this.picboxplanta.Image != global::Planta.Properties.Resources.crianca)
                    this.picboxplanta.Image = global::Planta.Properties.Resources.crianca;
                dados.EstagioCrescimento = 2;
            }
            else if (dados.HpMax < 250)
            {
                if (dados.Morrendo)
                {
                    if (this.picboxplanta.Image != global::Planta.Properties.Resources.adolescente_morrendo)
                        this.picboxplanta.Image = global::Planta.Properties.Resources.adolescente_morrendo;
                }
                else if (dados.Seca)
                {
                    if (this.picboxplanta.Image != global::Planta.Properties.Resources.adolescente_seca)
                        this.picboxplanta.Image = global::Planta.Properties.Resources.adolescente_seca;
                }
                else if (this.picboxplanta.Image != global::Planta.Properties.Resources.adolescente)
                    this.picboxplanta.Image = global::Planta.Properties.Resources.adolescente;
                dados.EstagioCrescimento = 3;
            }
            else if (dados.HpMax < 300)
            {
                if (dados.Morrendo)
                {
                    if (this.picboxplanta.Image != global::Planta.Properties.Resources.adulta_morrendo)
                        this.picboxplanta.Image = global::Planta.Properties.Resources.adulta_morrendo;
                }
                else if (dados.Seca)
                {
                    if (this.picboxplanta.Image != global::Planta.Properties.Resources.adulta_seca)
                        this.picboxplanta.Image = global::Planta.Properties.Resources.adulta_seca;
                }
                else if (this.picboxplanta.Image != global::Planta.Properties.Resources.adulta)
                    this.picboxplanta.Image = global::Planta.Properties.Resources.adulta;
                dados.EstagioCrescimento = 4;
            }
            else
            {
                if (dados.Morrendo)
                {
                    if (this.picboxplanta.Image != global::Planta.Properties.Resources.adulta_b_morrendo)
                        this.picboxplanta.Image = global::Planta.Properties.Resources.adulta_b_morrendo;
                }
                else if (dados.Seca)
                {
                    if (this.picboxplanta.Image != global::Planta.Properties.Resources.adulta_b_seca)
                        this.picboxplanta.Image = global::Planta.Properties.Resources.adulta_b_seca;
                }
                else if ((this.picboxplanta.Image != global::Planta.Properties.Resources.adulta_b) && !dados.Florescida)
                    this.picboxplanta.Image = global::Planta.Properties.Resources.adulta_b;
                else
                {
                    this.picboxplanta.Image = global::Planta.Properties.Resources.adulta_b_florescida;
                }
                dados.EstagioCrescimento = 5;
            }
        }

        public async Task VerificaSolo()
        {

            if (dados.Solo > 50) dados.Solo = 30;
            else if (dados.Solo < 0) dados.Solo = 0;

            if (dados.Solo < 0)
            {
                lbl_solo.Invoke(new Action(() => lbl_solo.Text = "péssimo"));
                lbl_solo.Invoke(new Action(() => lbl_solo.ForeColor = Color.DarkRed));
                BaseChanceEventualidade += 2;
                dados.Hp -= 2;
            }
           else if (dados.Solo < 20)
            {
                lbl_solo.Invoke(new Action(() => lbl_solo.Text = "Ruim"));
                lbl_solo.Invoke(new Action(() => lbl_solo.ForeColor = Color.DarkRed));
                BaseChanceEventualidade += 1;
                dados.Hp -= 1;
            }
            else if (dados.Solo < 30)
            {
                lbl_solo.Invoke(new Action(() => lbl_solo.Text = "Normal"));
                lbl_solo.Invoke(new Action(() => lbl_solo.ForeColor = Color.Gold));
            }
            else
            {
                lbl_solo.Invoke(new Action(() => lbl_solo.Text = "Bom"));
                lbl_solo.Invoke(new Action(() => lbl_solo.ForeColor = Color.Green));
                BaseChanceEventualidade -= 2;
            }
        }


        public async Task VerificaDanosEventualidades()
        {
            //dano de pulgões
            if (dados.Pulgoes)
            {
                dados.Solo -= 2;
                dados.Hp -= 2;
            }
            if (dados.Acaros)
            {
                dados.Hp -= 1;
            }
            //if (dados.Conchonilhas)
            //{
            //    dados.Solo -= 1;
            //    dados.Hp -= 1;
            //}
        }


        public async Task VerificaSituacao()
        {

            if ((dados.EstagioCrescimento == 5) && (dados.Hp > dados.HpMax + 20) && (dados.CicloFlorescimento < 15))
            {
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.Text = "Florescida"));
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.ForeColor = Color.Green));
                dados.Seca = false;
                BaseChanceEventualidade -= 3;
                dados.Solo += 2;
                dados.Sede -= 2;
                dados.Hp += 1;
                dados.Florescida = true;
                dados.CicloFlorescimento += 1;
            }
            else if (dados.Hp > dados.HpMax)
            {
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.Text = "Radiante"));
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.ForeColor = Color.Green));
                dados.Seca = false;
                BaseChanceEventualidade -= 2;
            }
            else if (dados.Hp < (dados.HpMax - 80))
            {
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.Text = "Morta"));
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.ForeColor = Color.Red));
                dados.Morta = true;
            }
            else if (dados.Hp < (dados.HpMax - 40))
            {
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.Text = "Fraca"));
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.ForeColor = Color.Red));
                dados.Morrendo = true;
                dados.Solo -= 1;
            }
            else if (dados.Hp < (dados.HpMax - 30))
            {
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.Text = "Triste"));
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.ForeColor = Color.Gold));
                dados.Morrendo = false;
                dados.Seca = true;
            }
            else if (dados.Hp < (dados.HpMax - 20))
            {
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.Text = "Feliz"));
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.ForeColor = Color.Green));
                BaseChanceEventualidade -= 1;
            }
            else
            {
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.Text = "Feliz"));
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.ForeColor = Color.Green));
                BaseChanceEventualidade -= 1;
            }

            //
            if (dados.Pulgoes)
            {
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.Text += " - Pulgões"));
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.ForeColor = Color.Gold));
            }
            //if (dados.Conchonilhas)
            //{
            //    lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.Text += " - Conchonilhas"));
            //    lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.ForeColor = Color.Gold));
            //}
            if (dados.Acaros)
            {
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.Text += " - Ácaros"));
                lbl_situacaohp.Invoke(new Action(() => lbl_situacaohp.ForeColor = Color.Gold));
            }
        }

        private void btnAguar_Click(object sender, EventArgs e)
        {
            if (dados.Pontos > 1)
            {
                dados.Sede = dados.Sede - 30;
                dados.Pontos -= 2;
                VerificaSede();
            }
            else
            {
                MessageBox.Show("Não tem pontos suficientes.");
            }
        }

        private void btnmeiaagua_Click(object sender, EventArgs e)
        {
            if (dados.Pontos > 0)
            {
                dados.Sede = dados.Sede - 15;
                dados.Pontos -= 1;
                VerificaSede();
            }
            else
            {
                MessageBox.Show("Não tem pontos suficientes.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!dados.PegandoSol)
            {
                dados.PegandoSol = true;
                btnjanela.Text = "Retirar da janela";
                btnjanela.BackColor = Color.DarkGoldenrod;
                btnjanela.FlatAppearance.BorderColor = Color.Gold;
            }
            else
            {
                dados.PegandoSol = false;
                btnjanela.Text = "Colocar na janela";
                btnjanela.BackColor = Color.DarkGreen;
                btnjanela.FlatAppearance.BorderColor = Color.LimeGreen;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_ctrl.TabIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("Deseja salvar e sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If the no button was pressed ...
            if (resp == DialogResult.Yes)
            {
                BL.SqLiteLogin.UptSave(dados);

                Saves login = new Saves();

                //Form1 login = new Form1();
                login.MdiParent = this.MdiParent;

                //login.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                login.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                login.Dock = DockStyle.Fill;

                login.Show();
            }

        }

        private void btn_loja_Click(object sender, EventArgs e)
        {
            tb_ctrl.SelectedTab = tabPage2;

            if (dados.Pulgoes)
            { btn_neen.Enabled = true; }
            //else if (dados.Conchonilhas)
            //{ btn_neen.Enabled = true; }
            else btn_neen.Enabled = false;
            if (dados.Acaros)
            { btn_antiacaro.Enabled = true; }
            else btn_antiacaro.Enabled = false;

            //if (dados.CicloFertilizante < 100)
            //{
            //    btn_fertilizante.Enabled = false;
            //}
            //else btn_fertilizante.Enabled = true;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            tb_ctrl.SelectedTab = tbpg_menu;
        }

        private void btn_neen_Click(object sender, EventArgs e)
        {

            if (dados.Pontos >= 5)
            {
                if (dados.Pulgoes)
                { dados.Pulgoes = false; dados.Pontos -= 5; }
            }
            else
            {
                MessageBox.Show("Não tem pontos suficientes.");
            }
        }

        private void btn_antiacaro_Click(object sender, EventArgs e)
        {
            if (dados.Pontos >= 3)
            {
                dados.Acaros = false;
                dados.Pontos -= 3;
            }
            else
            {
                MessageBox.Show("Não tem pontos suficientes.");
            }
        }

        private void btn_fertilizante_Click(object sender, EventArgs e)
        {
            if (dados.Pontos >= 10)
            {
                dados.Solo += 20;
                dados.Pontos -= 10;
            }
            else
            {
                MessageBox.Show("Não tem pontos suficientes.");
            }
        }

        private void picboxplanta_Click(object sender, EventArgs e)
        {

        }

        //private async void GeraClima()
        //{
        //    Random random = new Random();

        //    //chance de repetição de clima

        //    int chancerepeticao = random.Next(1, 100);

        //    if(chancerepeticao > 35)
        //    {
        //        //chance de 1% para cada valor
        //        int numero = random.Next(1, 100);

        //        //sol
        //        if (numero >= 1 && numero <= 35)
        //        {
        //            climaatual = clima.ensolarado;
        //        }
        //    }
        //}
    }
}
