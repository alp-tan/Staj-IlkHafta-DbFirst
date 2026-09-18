using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__301_EFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EframeworkEntities1 db = new EframeworkEntities1();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Guards.ToList();
            dataGridView1.DataSource = values;
            
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue = db.Guards.Find(id);
            db.Guards.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("rehber silindi");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RehberId_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guard guard = new Guard();
            guard.GuardName = txtName.Text;
            guard.GuardSurname = txtSurname.Text;
            db.Guards.Add(guard);
            db.SaveChanges();
            MessageBox.Show("rehber eklendi");



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                int id = int.Parse(txtId.Text);
            var updateValue = db.Guards.Find(id);
            updateValue.GuardName = txtName.Text;
            updateValue.GuardSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.Guards.Where(x => x.GuardId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
