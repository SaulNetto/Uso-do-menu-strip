using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploMenu
{
    public partial class FrmRosa : Form
    {
        public FrmRosa()
        {
            InitializeComponent();
        }

        private void ExibirFormRosa_Click(object sender, EventArgs e)
        {
            FrmRosa frm = new FrmRosa(); //Indico qual form será aberto
            this.Hide(); //Fechar o atual
            frm.ShowDialog();
        }

        private void ExibirFormAzul_Click(object sender, EventArgs e)
        {
            FrmAzul frm = new FrmAzul(); //Indico qual form será aberto
            this.Hide(); //Fechar o atual
            frm.ShowDialog();
        }

        private void ExibirFormVerde_Click(object sender, EventArgs e)
        {
            FrmVerde frm = new FrmVerde(); //Indico qual form será aberto
            this.Hide(); //Fechar o atual
            frm.ShowDialog();
        }
    }
}
