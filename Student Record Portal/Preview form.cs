using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Record_Portal
{
    public partial class Preview_form : Form
    {
        public Preview_form()
        {
            InitializeComponent();
        }

        public void PreviewStudent(int StudentRollNo, string FirstName, 
                  string LastName, string GuardianName, string Gender,
                  string DateOfBirth,string PhoneNo, string Address, 
                  string City, string Branch, string Religion)
        {
            lblStdRoll.Text = Convert.ToString(StudentRollNo);
            lblFirstNm.Text = FirstName;
            lblLastNm.Text = LastName;
            lblGuardianNm.Text = GuardianName;
            lblGender.Text = Gender;
            lblDob.Text = DateOfBirth;
            lblPhone.Text = PhoneNo;
            lblAddress.Text = Address;
            lblCity.Text = City;
            lblBranch.Text = Branch;
            lblReligion.Text = Religion;
        }
        public void Preview_form_Load(object sender, EventArgs e)
        {
           
        }
    }
}
