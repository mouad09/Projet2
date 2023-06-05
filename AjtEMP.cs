using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_ENTREPRISE
{
    public partial class AjtEMP : Form
    {
       // SqlConnection cnx = new SqlConnection(@"Data Source=.;Initial Catalog=GESTION_ENTREPRISE;Integrated Security=True");
        public AjtEMP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string radioButton;
            try
            {
                CLA.cns.Open();
                if (radioButton1.Checked == true)
                {
                    radioButton = radioButton1.Text;
                }
                else 
                {
                    radioButton = radioButton2.Text;
                }
                CLA.DR.CommandText = "insert into Employé values (" + textBox1NUM.Text + ",'" + textBox2NOM.Text + "','" + textBox3PRENOM.Text + "','" + radioButton + "','" + textBox4DN.Text + "','" + textBox5FONCTION.Text + "')";
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

        private void AjtEMP_Load(object sender, EventArgs e)
        {

        }
    }
}
