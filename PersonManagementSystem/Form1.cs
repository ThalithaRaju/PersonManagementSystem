using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonManagementSystem
{
    public partial class Form1 : Form
    {
        Person p = new Person();
        public Form1()
        {
            InitializeComponent();
        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSave_Click(object sender, EventArgs e)

        {

            try
            {


                if ((textId.Text != string.Empty) && (txtAge.Text != string.Empty) && (txtName.Text != string.Empty))
                {



                    if (Convert.ToInt32(txtAge.Text) >= 5 && (Convert.ToInt32(txtAge.Text) <= 60))
                    {
                        p.id = Convert.ToInt32(textId.Text);
                        p.name = comb1.Text + " " + txtName.Text;
                        p.Age = Convert.ToInt32(txtAge.Text);

                        txtAge.Text = string.Empty;
                        txtName.Text = string.Empty;
                        textId.Text = string.Empty;
                        comb1.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Limit should be 5-60 !", "Person Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAge.Text = "";
                    }
                }



                else
                {
                    MessageBox.Show("Fields Required", "Person Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Invalid", "person management system", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            
            lblId.Text = p.id.ToString();
            lblName.Text = p.name;
            lblAge.Text = p.Age.ToString();
            if (Convert.ToInt32(lblAge.Text)<18)
            {
                lblAge.BackColor = Color.Red;
            }
            else if(Convert.ToInt32(lblAge.Text)>50)
            {
                lblAge.BackColor = Color.Green;
            }
            
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            lblId.Text = "";
            lblName.Text = "";
            lblAge.Text = "";
            
        }
    }
}
