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
    public partial class Revisar : Form
    {
        public Revisar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente cancelar?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (!result.Equals(DialogResult.Cancel))
                this.Close();
        }
    }
}
