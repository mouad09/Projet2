using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_ENTREPRISE
{
    public partial class CSLT0 : Form
    {
        public CSLT0()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consulter cstt = new Consulter();
            cstt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CST_PRJ02 CST = new CST_PRJ02();
            CST.ShowDialog();
        }
    }
}
