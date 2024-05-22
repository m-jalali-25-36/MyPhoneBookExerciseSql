using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhoneBook2
{
    public partial class MyPhoneBookMain : Form
    {
        private Person per = new Person();
        public MyPhoneBookMain()
        {
            InitializeComponent();
            btnEdit.Enabled = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEdit.Enabled)
                    return;
                per.Id = Guid.NewGuid();
                per.NationalCode = tbxNC.Text;
                per.FirstName = tbxFirstName.Text;
                per.FamilyName = tbxLastName.Text;
                per.FatherName = tbxFatherName.Text;
                per.Adress = tbxAddress.Text;
                per.Birthday = stBirthday.Value;
                per.Gender = rbMan.Checked;
                MyNoteBookEntities db = new MyNoteBookEntities();
                db.Person.Add(per);
                db.SaveChanges();
                MessageBox.Show("Successful Add", "Message");
                btnClear_Click(null, null);
            }
            catch (Exception ex)
            {
                string innerEx = ex.InnerException != null ? $"\nInnerException: {ex.InnerException.Message} " : "";
                MessageBox.Show($"Error!!\nMessage: {ex.Message}{innerEx}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MyPhoneBookMain_Load(null, null);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    per.Id = (Guid)dataGridView1.SelectedRows[0].Cells[0].Value;
                    tbxNC.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    tbxFirstName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    tbxLastName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    tbxFatherName.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    tbxAddress.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    stBirthday.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                    rbMan.Checked = (bool)(dataGridView1.SelectedRows[0].Cells[7].Value);
                    rbWoman.Checked = !rbMan.Checked;
                    btnEdit.Enabled = true;
                    btnAdd.Enabled = false;
                }
                catch (Exception ex)
                {
                    string innerEx = ex.InnerException != null ? $"\nInnerException: {ex.InnerException.Message} " : "";
                    MessageBox.Show($"Error!!\nMessage: {ex.Message}{innerEx}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); btnEdit.Enabled = false;
                    btnAdd.Enabled = true;
                }
            }

        }

        private void MyPhoneBookMain_Load(object sender, EventArgs e)
        {
            try
            {
                MyNoteBookEntities db = new MyNoteBookEntities();
                dataGridView1.DataSource = db.Person.ToList();
            }
            catch (Exception ex)
            {
                string innerEx = ex.InnerException != null ? $"\nInnerException: {ex.InnerException.Message} " : "";
                MessageBox.Show($"Error!!\nMessage: {ex.Message}{innerEx}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (!btnEdit.Enabled)
                    return;
                MyNoteBookEntities db = new MyNoteBookEntities();
                if (!db.Person.Any(p => p.Id == per.Id))
                {
                    MessageBox.Show("Not Find to Edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                per.NationalCode = tbxNC.Text;
                per.FirstName = tbxFirstName.Text;
                per.FamilyName = tbxLastName.Text;
                per.FatherName = tbxFatherName.Text;
                per.Adress = tbxAddress.Text;
                per.Birthday = stBirthday.Value;
                per.Gender = rbMan.Checked;

                db.Entry(per).State = EntityState.Modified;
                db.SaveChanges();
                //db.Entry(old).State = EntityState.Detached;
                //db.Person.Attach(per);
                //db.Entry(per).State = EntityState.Modified;
                //db.SaveChanges();
            }
            catch (Exception ex)
            {
                string innerEx = ex.InnerException != null ? $"\nInnerException: {ex.InnerException.Message} " : "";
                MessageBox.Show($"Error!!\nMessage: {ex.Message}{innerEx}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEdit.Enabled = false;
                btnAdd.Enabled = true;
            }
            MyPhoneBookMain_Load(null, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxNC.Text = "";
            tbxFirstName.Text = "";
            tbxLastName.Text = "";
            tbxFatherName.Text = "";
            tbxAddress.Text = "";
            stBirthday.Value = DateTime.Now;
            rbMan.Checked = true;
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("First Select Row for Delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MyNoteBookEntities db = new MyNoteBookEntities();
                Guid id = (Guid)dataGridView1.SelectedRows[0].Cells[0].Value;
                Person p = db.Person.Find(id);
                if (p == null)
                {
                    MessageBox.Show("Not Find to Object!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (db.Entry(p).State == EntityState.Detached)
                {
                    db.Person.Attach(p);
                }
                db.Person.Remove(p);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                string innerEx = ex.InnerException != null ? $"\nInnerException: {ex.InnerException.Message} " : "";
                MessageBox.Show($"Error!!\nMessage: {ex.Message}{innerEx}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); MessageBox.Show($"Error!!\nMessage: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEdit.Enabled = false;
            }
            MyPhoneBookMain_Load(null, null);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                string s = tbxSearch.Text;
                MyNoteBookEntities db = new MyNoteBookEntities();
                if (string.IsNullOrEmpty(s))
                    dataGridView1.DataSource = db.Person.ToList();
                else
                    dataGridView1.DataSource = db.Person.Where(
                        q =>
                    q.NationalCode.Contains(s) ||
                    q.FirstName.Contains(s) ||
                    q.FamilyName.Contains(s) ||
                    q.FatherName.Contains(s)).ToList();
            }
            catch (Exception ex)
            {
                string innerEx = ex.InnerException != null ? $"\nInnerException: {ex.InnerException.Message} " : "";
                MessageBox.Show($"Error!!\nMessage: {ex.Message}{innerEx}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
