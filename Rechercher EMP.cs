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
    public partial class Rechercher_EMP : Form
    {
        public Rechercher_EMP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rechercher_EMP_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("NumEmployé", "NumEmployé");
            dataGridView1.Columns.Add("NomEmployé", "NomEmployé");
            dataGridView1.Columns.Add("PrenomEmployé", "PrenomEmployé");
            dataGridView1.Columns.Add("SexeEmployé", "SexeEmployé");
            dataGridView1.Columns.Add("DNaissEmplyé", "DNaissEmplyé");
            dataGridView1.Columns.Add("FonctionEmployé", "FonctionEmployé");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //pour eviter repetition dans datagridview
                dataGridView1.Rows.Clear();
                CLA.cns.Open();
                if (radioButton1.Checked == true)
                {
                    CLA.DR.CommandText = "select NumEmployé,NomEmployé,PrenomEmployé,SexeEmployé,DNaissEmployé,FonctionEmployé from employé where NomEmployé = '" + textBox3.Text + "'";
                    CLA.dr = CLA.DR.ExecuteReader();
                    while (CLA.dr.Read())
                    {
                        dataGridView1.Rows.Add(CLA.dr[0], CLA.dr[1], CLA.dr[2], CLA.dr[3], CLA.dr[4], CLA.dr[5]);
                    }
                }

                if (radioButton2.Checked == true)
                {
                    CLA.DR.CommandText = "select NumEmployé,NomEmployé,PrenomEmployé,SexeEmployé,DNaissEmployé,FonctionEmployé from employé where PrenomEmployé = '" + textBox2.Text + "'";
                    CLA.dr = CLA.DR.ExecuteReader();
                    while (CLA.dr.Read())
                    {
                        dataGridView1.Rows.Add(CLA.dr[0], CLA.dr[1], CLA.dr[2], CLA.dr[3], CLA.dr[4], CLA.dr[5]);
                    }
                }

                if (radioButton3.Checked == true)
                {
                    CLA.DR.CommandText = "select NumEmployé,NomEmployé,PrenomEmployé,SexeEmployé,DNaissEmployé,FonctionEmployé from employé where FonctionEmployé = '" + textBox1.Text + "'";
                    CLA.dr = CLA.DR.ExecuteReader();
                    while (CLA.dr.Read())
                    {
                        dataGridView1.Rows.Add(CLA.dr[0], CLA.dr[1], CLA.dr[2], CLA.dr[3], CLA.dr[4], CLA.dr[5]);
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