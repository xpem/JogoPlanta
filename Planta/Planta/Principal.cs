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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Saves login = new Saves();

            //Form1 login = new Form1();
            login.MdiParent = this;

            //login.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            login.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            login.Dock = DockStyle.Fill;
            
            login.Show();


        }
    }
}
