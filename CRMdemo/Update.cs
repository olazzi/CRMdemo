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
    
    public partial class Update : Form
    {
        
       



        public Update()
        {
            InitializeComponent();
           
           
        }
        
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form3 form3 = new Form3();
            
            if (textBox1.Text == null)
            {
                //label9.Visible = true;
            }
            else
            {
              
                button1.Enabled = false;
                using (var db = new DataClasses1DataContext())
                {



                    //Form3 form3 = new Form3();
                    int barID = 0;
                    //update.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    
        //DataGridViewCell cell1 = form3.dataGridView1.SelectedRows[0].Cells[1];
        //string id1 = form3.dataGridView1.Rows[].;
        //Int32 id1 = Convert.ToInt32(form3.dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString());
        // int userid = Convert.ToInt32(form3.dataGridView1.CurrentRow.Cells[0].Value);
        // int selectedUser = Convert.ToInt32(form3.dataGridView1.CurrentRow.Cells[0].Value);
        //int rowIndex = form3.dataGridView1.CurrentRow.Index;

        //Pass to local Variable
        //barID = Convert.ToInt32(form3.dataGridView1.Rows[rowIndex].Cells[0].Value);
        //DataGridViewRow row1 = form3.dataGridView1.Rows[rowIndex];
        db.tblProjects
                    .Where(x => Convert.ToString(x.Id) == "1")
                    .ToList()
                    .ForEach(a =>
                    {
                        a.Name = textBox1.Text;
                        a.Website = textBox2.Text;
                        a.Instagram = textBox3.Text;
                        a.Twitter = textBox4.Text;
                        a.Facebook = textBox5.Text;
                        a.LinkedIn = textBox6.Text;
                        a.Youtube = textBox7.Text;
                    });
                     db.SubmitChanges();
                    



                    /* crm.Id = Convert.ToInt32(textBox2.Text);
                    crm.Name = textBox1.Text;
                    crm.Website = textBox2.Text;
                    crm.Instagram = textBox3.Text;
                    crm.Twitter = textBox4.Text;
                    crm.Facebook = textBox5.Text;
                    crm.LinkedIn = textBox6.Text;
                    crm.Youtube = textBox7.Text;
                    */
                    //crm.Deleted = Convert.ToInt32("0");
                    // db.tblProjects.InsertOnSubmit(crm);
                    // db.SubmitChanges();

                }
            }
        }
    }
}
