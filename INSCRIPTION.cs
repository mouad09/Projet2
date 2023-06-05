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
    public partial class INSCRIPTION : Form
    {
        public INSCRIPTION()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjtEMP ajt = new AjtEMP();
            ajt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CLA.cns.Open();

               
                CLA.DR.CommandText = "insert into  inscription values (" + comboBox1.SelectedItem + ",'" + comboBox1.SelectedItem + "','" + dateTimePicker1.Value + "')";

                if (CLA.DR.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Ajoute effectuer");
                }
                CLA.cns.Close();

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
                CLA.cns.Close();
            }
        }

        private void INSCRIPTION_Load(object sender, EventArgs e)
        {
            try
            {
                CLA.cns.Open();
                CLA.DR.CommandText = "select NumEmployé from Employé ";
                CLA.dr = CLA.DR.ExecuteReader();
                while (CLA.dr.Read())
                {
                    comboBox1.Items.Add(CLA.dr["NumEmployé"]);
                }
                CLA.cns.Close();

                CLA.cns.Open();
                CLA.DR.CommandText = "select codeProjet from Projet ";
                CLA.dr = CLA.DR.ExecuteReader();
                while (CLA.dr.Read())
                {
                    comboBox2.Items.Add(CLA.dr["codeProjet"]);
                }
                CLA.cns.Close();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
                CLA.cns.Close();
            }
        }
    }
}
