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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjtEMP ajtemp = new AjtEMP();
            ajtemp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjtPRJ ajtprj = new AjtPRJ();
            ajtprj.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            INSCRIPTION insc = new INSCRIPTION();
            insc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CONSulter_EMP stlemp = new CONSulter_EMP();
            stlemp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CONSulter_EMP cst = new CONSulter_EMP();
            cst.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rechercher_EMP rch = new Rechercher_EMP();
            rch.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CSLT0 cst0 = new CSLT0();
            cst0.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
