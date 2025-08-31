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
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;

        

        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

          
            this.Load += FrmConfirm_Load;
            this.FormClosing += FrmConfirm_FormClosing;
            btnSubmit.Click += btnSubmit_Click;
        
    }
        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblStudentNoVal.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            lblProgramVal.Text = DelProgram(StudentInfoClass.Program);
            lblLastNameVal.Text = DelLastName(StudentInfoClass.LastName);
            lblFirstNameVal.Text = DelFirstName(StudentInfoClass.FirstName);
            lblMiddleNameVal.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblAgeVal.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblContactNoVal.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            lblAddressVal.Text = DelAddress(StudentInfoClass.Address);
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
