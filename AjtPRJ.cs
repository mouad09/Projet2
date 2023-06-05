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
    public partial class AjtPRJ : Form
    {
        public AjtPRJ()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TypePRJ typeprj = new TypePRJ();
            typeprj.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AjtPRJ_Load(object sender, EventArgs e)
        {
            try
            {
                CLA.cns.Open();
                CLA.DR.CommandText = "select TypeProjet from TypeProjet";
                CLA.dr = CLA.DR.ExecuteReader();
                while(CLA.dr.Read())
                {
                    
                    comboBox1.Items.Add(CLA.dr["TypeProjet"]);
                }
                CLA.cns.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CLA.cns.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CLA.cns.Open();
                // CLA.cmd.CommandText = "insert into Projet values  "  + textBox1.Text + ",'" + comboBox1.SelectedItem + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "')";
                CLA.DR.CommandText = "insert into projet  values(" + textBox1.Text + ",'" + comboBox1.SelectedItem + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "')";
                if (CLA.DR.ExecuteNonQuery() >= 1)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
