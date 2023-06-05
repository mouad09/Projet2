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
    public partial class Consulter : Form
    {
        public Consulter()
        {
            InitializeComponent();
        }

        private void Consulter_Load(object sender, EventArgs e)
        {
            //remplir datagradiveiw avec la liste des projet 
            dataGridView1.Columns.Add("CodeProjet", "CodeProjet");
            dataGridView1.Columns.Add("TypeProjet", "TypeProjet");
            dataGridView1.Columns.Add("DateDebut", "DateDebut");
            dataGridView1.Columns.Add("DateFin", "DateFin");
            try
            {

                //pour eviter repetition dans datagridview
                dataGridView1.Rows.Clear();
                CLA.cns.Open();
                if (true)
                {
                    CLA.DR.CommandText = "select codeProjet,TypeProjet,DateDebut,DateFin from Projet ";
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

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AjtPRJ isc = new AjtPRJ();
            isc.ShowDialog();
        }
    }
}
