using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artigos
{
    public partial class Dashboard : Form
    {
            //1 - Autores
            //2 - Revisores
            //3 - Gerente
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var frmLogin = new Login();
            frmLogin.ShowDialog();

            if (frmLogin.logado == false) {
                Close();

            }

            if (Login.perfilUsuario == 3)
            {
                button1.Enabled = true;
            }
            else if (Login.perfilUsuario == 1)
            {
                button1.Enabled = false;
                btnRevisarArtigo.Enabled = false;
            }
            else
            {
                btnCadastrarArtigo.Enabled = false;
                button1.Enabled = false;
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cad = new Cadastrar();
            cad.ShowDialog();
         
        }

        private void btnCadastrarArtigo_Click(object sender, EventArgs e)
        {
            var art = new Artigo();
            art.ShowDialog();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rev = new Revisar();
            rev.ShowDialog();
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var log = new Login();
            log.ShowDialog();
            
            
        }
    }
}
