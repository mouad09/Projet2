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
    public partial class CONSulter_EMP : Form
    {
        public CONSulter_EMP()
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


                CLA.DR.CommandText = "update employé set nomEmployé ='" + textBox1.Text.Replace("'", "'") + "'," +
                "PrenomEmployé ='" + textBox2.Text.Replace("'", "'") + "'," + "sexeEmployé ='" + textBox3.Text.Replace("'", "'") + "'," +
                "DNaissEmployé ='" + textBox4.Text.Replace("'", "'") + "'," + "FonctionEmployé ='" + textBox5.Text.Replace("'", "''") +
                "' where numEmployé=" + comboBox1.SelectedItem;
                if (CLA.DR.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("MODIFICATION  EFFECTUER");
                }


                CLA.cns.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CLA.cns.Close();
            }
        }

        private void CONSulter_EMP_Load(object sender, EventArgs e)
        {
            try
            {
                CLA.cns.Open();


               CLA.DR.CommandText = "select numEmployé from employé";
               CLA.dr = CLA.DR.ExecuteReader();
                while (CLA.dr.Read())
                {
                    comboBox1.Items.Add(CLA.dr["numEmployé"]);
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
            CLA.cns.Open();
            CLA.DR.CommandText = "select NomEmployé,PrenomEmployé,SexeEmployé,DNaissEmployé,FonctionEmployé from Employé  where NumEmployé=" + comboBox1.SelectedItem;
            CLA.dr = CLA.DR.ExecuteReader();
            while (CLA.dr.Read())
            {
                textBox1.Text = CLA.dr["NomEmployé"].ToString();
                textBox2.Text = CLA.dr["PrenomEmployé"].ToString();
                textBox3.Text = CLA.dr["sexeEmployé"].ToString();
                textBox4.Text = CLA.dr["DNaissEmployé"].ToString();
                textBox5.Text = CLA.dr["FonctionEmployé"].ToString();
            }
            CLA.cns.Close();

        }
    }
}
