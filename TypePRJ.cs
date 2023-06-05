using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GESTION_ENTREPRISE
{
    public partial class TypePRJ : Form
    {
        public TypePRJ()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CLA.cns.Open();
                CLA.DR.CommandText = "insert into TypeProjet values ('" + textBox1.Text +"','"+textBox2.Text +"','"+textBox3.Text + "')";
                if (CLA.DR.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("ajoute effectuer ");
                }
                CLA.cns.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CLA.cns.Close();
            }
        }
    }
}
