using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMdemo
{
    public partial class Form1 : Form
    {
        int id, deleted;
        public string name, website, instagram, twitter, facebook, linkedIn, youtube;

        public string asd = "asd";
        public Form1()
        {
            InitializeComponent();
            label8.Visible = false;
            label9.Visible = false;
        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            linkedIn = textBox1.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            youtube = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (name == null)
            {
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
                button2.Enabled = false;
                label8.Visible = true;
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    tblProject crm = new tblProject();
                    // crm.Id = Convert.ToInt32(textBox2.Text);
                    crm.Name = textBox1.Text;
                    crm.Website = textBox3.Text;
                    crm.Instagram = textBox4.Text;
                    crm.Twitter = textBox5.Text;
                    crm.Facebook = textBox6.Text;
                    crm.LinkedIn = textBox7.Text;
                    crm.Youtube = textBox8.Text;
                    crm.Deleted = Convert.ToInt32("0");
                    db.tblProjects.InsertOnSubmit(crm);
                    db.SubmitChanges();

                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Visible = true;
           


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            facebook = textBox1.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            twitter = textBox1.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            instagram = textBox1.Text;
        }

        

        /*
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            id = int.Parse(textBox2.Text);
        }
        */


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            website = textBox1.Text;
        }

     

     
      

       
    }
}
