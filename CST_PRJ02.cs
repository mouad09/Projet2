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
    public partial class CST_PRJ02 : Form
    {
        public CST_PRJ02()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            INSCRIPTION ins = new INSCRIPTION();
            ins.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CST_PRJ02_Load(object sender, EventArgs e)
        {
            //remplir combobox avec les code projet 
            dataGridView1.Columns.Add("CodeProjet", "CodeProjet");
            dataGridView1.Columns.Add("TypeProjet", "TypeProjet");
            dataGridView1.Columns.Add("DateDebut", "DateDebut");
            dataGridView1.Columns.Add("DateFin", "DateFin");
            try
            {
                CLA.cns.Open();
                CLA.DR.CommandText = "select codeprojet from projet";
                CLA.dr = CLA.DR.ExecuteReader();
                while (CLA.dr.Read())
                {
                    comboBox1.Items.Add(CLA.dr["codeprojet"]);

                }
                CLA.cns.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CLA.cns.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //pour eviter repetition dans datagridview
                dataGridView1.Rows.Clear();
                CLA.cns.Open();
                if (true)
                {
                    CLA.DR.CommandText = "select codeProjet,TypeProjet,DateDebut,DateFin from Projet where codeprojet = '" + comboBox1.SelectedItem + "'";
                    CLA.dr = CLA.DR.ExecuteReader();
                    while (CLA.dr.Read())
                    {
                        dataGridView1.Rows.Add(CLA.dr[0], CLA.dr[1], CLA.dr[2], CLA.dr[3]);

                    }

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
