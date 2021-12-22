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
    
    public partial class Form3 : Form
    {


        public string name;

        public Form3()
        {
           
            InitializeComponent();
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            Cursor.Current = Cursors.WaitCursor;
            using (DataClasses1DataContext dt2 = new DataClasses1DataContext())
            {
                List<tblProject> list = dt2.tblProjects.Where(w => w.Deleted == 0).ToList();
                foreach (tblProject p in list)
                {
                    ListViewItem item = new ListViewItem(p.Id.ToString());
                    item.SubItems.Add(p.Name);
                    item.SubItems.Add(p.Website);
                    item.SubItems.Add(p.Instagram);
                    item.SubItems.Add(p.Twitter);
                    item.SubItems.Add(p.Facebook);
                    item.SubItems.Add(p.LinkedIn);
                    item.SubItems.Add(p.Youtube);
                    listView1.Items.Add(item);
                }
            }
            Cursor.Current = Cursors.Default;


        }


       



    public void Form3_Load(object sender, EventArgs e)
        {
            
        DataClasses1DataContext dt1 = new DataClasses1DataContext();

            var tbl = from p in dt1.tblProjects where p.Deleted == 0
                      select new
                      {
                          p.Id,
                          p.Name,
                          p.Website,
                          p.Instagram,
                          p.Twitter,
                          p.Facebook,
                          p.LinkedIn,
                          p.Youtube
                      };
           
            //dataGridView1.DataSource = tbl;
            //name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            

            //listBox1.DataSource = tbl;


            
        }
        static int x = 150;
        static int y = 150;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[7].Text;


            /*            
            Update update = new Update();
            
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            update.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            update.textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            update.textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            update.textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            update.textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            

            update.textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            update.textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            update.textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            update.textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            update.textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            update.textBox6.Text = listView1.SelectedItems[0].SubItems[6].Text;
            update.textBox7.Text = listView1.SelectedItems[0].SubItems[7].Text;
            

            update.ShowDialog();
            //this.Hide();
            */
        }
        


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            // Update update = new Update();
            //update.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //update.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //update.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //update.ShowDialog();

            
            //update.label1.Text = " ";
            //.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //update.textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            // namec = dataGridView1.CurrentRow.Cells[2].RowIndex.ToString();
            //update.textBox1.Text = namec;
            //update.label1.Text = namec;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;
            //dataGridView1.Rows[index].Selected = true;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine(name);
            Update update = new Update();
            /*
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            update.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            update.textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            update.textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            update.textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            update.textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            */
            //update.textBox1.Text = listView1.SelectedItems[0].Text;
            update.ShowDialog();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (DataClasses1DataContext dt2 = new DataClasses1DataContext())
            {
                List<tblProject> list = dt2.tblProjects.Where(w=> w.Deleted==0).ToList();
                foreach(tblProject p in list)
                {
                    ListViewItem item = new ListViewItem(p.Id.ToString());
                    item.SubItems.Add(p.Name);
                    item.SubItems.Add(p.Website);
                    item.SubItems.Add(p.Instagram);
                    item.SubItems.Add(p.Twitter);
                    item.SubItems.Add(p.Facebook);
                    item.SubItems.Add(p.LinkedIn);
                    item.SubItems.Add(p.Youtube);
                    listView1.Items.Add(item);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Visible = true;

            /*
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[7].Text;
            */
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                
                label10.Visible = true;
                timer2.Interval = 2000;
                timer2.Enabled = true;
            }
            else
            {
                using (var db = new DataClasses1DataContext())
                {
                    db.tblProjects
                       .Where(x => Convert.ToString(x.Id) == listView1.SelectedItems[0].SubItems[0].Text)
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
                }
                button4.Enabled = false;
                label8.Visible = true;
                timer1.Interval = 2000;
                timer1.Enabled = true;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[7].Text;
            button4.Enabled = true;
            button5.Enabled = true;
            button1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            using (var db = new DataClasses1DataContext())
            {
                db.tblProjects
                   .Where(x => Convert.ToString(x.Id) == listView1.SelectedItems[0].SubItems[0].Text)
                   .ToList()
                   .ForEach(a =>
                   {
                       a.Deleted = 1;
                   });
                db.SubmitChanges();
            }
            label9.Visible = true;
            button5.Enabled = false;
            timer1.Interval = 2000;
            timer1.Enabled = true;
            button4.Enabled = false;
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Visible = false;
            label9.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label10.Visible = false;
        }
    }
}
