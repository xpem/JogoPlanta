using ML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planta
{
    public partial class Saves : Form
    {


        private List<ML.SaveItem> saves;

        public Saves()
        {
            InitializeComponent();
        }

        private void dataRepeater1_CurrentItemIndexChanged(object sender, EventArgs e)
        {

        }

        private void Saves_Load(object sender, EventArgs e)
        {
            CarregaSaves();
        }


        private void CarregaSaves()
        {
            saves = BL.SqLiteLogin.RecSaves();
           
            lbl_status.DataBindings.Clear();
            lbl_status.DataBindings.Add("Text", saves, "Status");
            lbl_hp.DataBindings.Clear();
            lbl_hp.DataBindings.Add("Text", saves, "Hp");
            lbl_nivel.DataBindings.Clear();
            lbl_nivel.DataBindings.Add("Text", saves, "EstagioCrescimento");

            dataRepeater1.DataSource = saves;
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            int indice = dataRepeater1.CurrentItem.ItemIndex;

           ML.Dados dado =  BL.SqLiteLogin.RecDados( saves[indice].Id);
            Home home = new Home(dado);
            home.MdiParent = this.MdiParent;

            home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            home.Dock = DockStyle.Fill;

            home.Show();
            this.Close();

        }

        private void btn_novo_jogo_Click(object sender, EventArgs e)
        {

            Dados dados = new Dados();
            dados.Hp = dados.HpMax = 100;
            dados.Solo = 30;
            dados.Seca = false;
            dados.Morrendo = dados.Morta = false;
            dados.Pontos = 0;
            dados.CiclosEventualidade = 0;
            dados.ID = BL.SqLiteLogin.CadSave(dados);
            Home home = new Home(dados);
            home.MdiParent = this.MdiParent;

            home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            home.Dock = DockStyle.Fill;

            home.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = dataRepeater1.CurrentItem.ItemIndex;

            var resp = MessageBox.Show("Deseja excluir este save?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If the no button was pressed ...
            if (resp == DialogResult.Yes)
            {
                ML.SaveItem item = saves[indice];

                BL.SqLiteLogin.DelSave(item.Id);

                MessageBox.Show("Save excluído!");
                CarregaSaves();
            }

        }
    }
}
