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
    public partial class Artigo : Form
    {
        public Artigo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void criarArtigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            button1.Show();
            button2.Show();
            label1.Show();
            label2.Show();
            comboBox1.Show();
            textBox2.Show();
            label3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Artigo_Load(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            textBox1.Hide();
            label1.Hide();
            label2.Hide();
            comboBox1.Hide();
            textBox2.Hide();
            label3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Deseja realmente cancelar?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (!result.Equals(DialogResult.Cancel))
                this.Close();
            
        }
    }
}
