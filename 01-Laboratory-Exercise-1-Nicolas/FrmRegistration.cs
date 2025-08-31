using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Laboratory_Exercise_1_Nicolas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.LastName = txtLastName.Text.Trim();
            StudentInfoClass.FirstName = txtFirstName.Text.Trim();
            StudentInfoClass.MiddleName = txtMiddleName.Text.Trim();
            StudentInfoClass.Address = txtAddress.Text.Trim();
            StudentInfoClass.Program = (cbProgram.SelectedItem ?? cbProgram.Text).ToString();

            // Validate/parse numeric inputs
            if (!long.TryParse(txtStudNo.Text.Trim(), out var studNo))
            { MessageBox.Show("Enter a valid Student No (numbers only)."); txtStudNo.Focus(); return; }

            if (!long.TryParse(txtAge.Text.Trim(), out var age))
            { MessageBox.Show("Enter a valid Age (numbers only)."); txtAge.Focus(); return; }

            if (!long.TryParse(txtContactNo.Text.Trim(), out var contact))
            { MessageBox.Show("Enter a valid Contact No (numbers only)."); txtContactNo.Focus(); return; }

            StudentInfoClass.StudentNo = studNo;
            StudentInfoClass.Age = age;
            StudentInfoClass.ContactNo = contact;

            // 11–12: Show confirm as dialog; if OK, reset controls
            using (var confirm = new FrmConfirm())
            {
                var result = confirm.ShowDialog(this);
                if (result == DialogResult.OK)
                    ResetAll();
            }
        }

        private void ResetAll()
        {
            txtStudNo.Clear();
            cbProgram.SelectedIndex = -1;
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtAge.Clear();
            txtContactNo.Clear();
            txtAddress.Clear();
            txtLastName.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

