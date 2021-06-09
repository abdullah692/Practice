using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;


namespace Student_Record_Portal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string gender;
        string religion;

        //Regular Expression 
        Regex objStdID = new Regex("^[0-9]{2,4}$");
        Regex objFirstNm = new Regex("^[A-Z][a-zA-Z]*$");
        Regex objLastNm = new Regex("^[A-Z][a-zA-Z]*$");
        Regex ObjGurdNm = new Regex("^[A-Z][a-zA-Z]*$");

        //Clear Control method
        public void Clear_control()
        {
            txt_stdRoll.Clear();
            txt_FirstNm.Text = "";
            txt_LastNm.Text = "";
            txt_GuardianNm.Clear();
            rdb_male.Checked = false;
            rdb_female.Checked = false;
            dob.Value = new DateTime(1992, 12, 1);
            txt_phoneNo.Clear();
            txt_address.Clear();
            txt_city.Clear();
            cmb_branch.Text = "Select the Branch";
            rdb_muslim.Checked = false;
            rdb_non_muslim.Checked = false;
        }
        //Checked_Control Method
        private void Check_Control()
        {
            //Gender Control
            if (rdb_male.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            //Religion
            if (rdb_muslim.Checked == true)
            {
                religion = "Muslim";
            }
            else
            {
                religion = "Non-Muslim";

            }
        }
        //Explicit Expression
        private bool Control_Validate()
        {
            //Student RollNo Expression
            if (Convert.ToInt32(txt_stdRoll.Text.Length) < 1)
            {
                MessageBox.Show("Please!Enter the Student Roll No", "STUDENT ROLL NO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_stdRoll.Focus();
                txt_stdRoll.BackColor = Color.Silver;
                return false;
            }
            else if (!objStdID.IsMatch(txt_stdRoll.Text))
            {
                MessageBox.Show("Please! Enter the correct Roll No", "Student Roll No", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_stdRoll.Focus();
                txt_stdRoll.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txt_stdRoll.BackColor = Color.White;
            }
            //First name expression
            if (txt_FirstNm.Text == "")
            {
                MessageBox.Show("Please !Enter the First Name", "FIRST NAME ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_FirstNm.Focus();
                txt_FirstNm.BackColor = Color.Silver;
                return false;
            }
            else if (!objFirstNm.IsMatch(txt_FirstNm.Text))
            {
                MessageBox.Show("Please! Enter the correct First Name", "First Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_FirstNm.Focus();
                txt_FirstNm.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txt_FirstNm.BackColor = Color.White;
            }
            if (txt_LastNm.Text == "")
            {
                MessageBox.Show("PLease!Enter the Last Name", "LAST NAME ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LastNm.Focus();
                txt_LastNm.BackColor = Color.Silver;
                return false;
            }
            else if (!objLastNm.IsMatch(txt_LastNm.Text))
            {
                MessageBox.Show("Please! Enter the correct Last Name", "Last Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LastNm.Focus();
                txt_LastNm.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txt_LastNm.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(txt_GuardianNm.Text))
            {
                MessageBox.Show("PLease!Enter the Guardian Name", "GUARDIAN NAME ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LastNm.Focus();
                txt_LastNm.BackColor = Color.Silver;
                return false;
            }
            else if (!ObjGurdNm.IsMatch(txt_GuardianNm.Text))

            {
                MessageBox.Show("Please! Enter the correct Guardian Name", "Guardian Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_GuardianNm.Focus();
                txt_GuardianNm.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txt_LastNm.BackColor = Color.White;
            }
            if (rdb_male.Checked == false && rdb_female.Checked == false)
            {
                MessageBox.Show("PLease! Select the Gender", "GENDER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rdb_male.ForeColor = Color.Red;
                rdb_female.ForeColor = Color.Red;
                return false;
            }
            else
            {
                if (rdb_male.Checked == true)
                {
                    rdb_male.ForeColor = Color.LightGreen;
                    rdb_female.ForeColor = Color.LightPink;
                }
                else
                {
                    rdb_female.ForeColor = Color.LightGreen;
                    rdb_male.ForeColor = Color.LightPink;
                }

            }

            if (txt_phoneNo.Text == "")
            {
                MessageBox.Show("PLease!Enter the Phone Number", "PHONE NUMBER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_phoneNo.Focus();
                txt_phoneNo.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txt_phoneNo.BackColor = Color.White;
            }
            if (txt_address.Text == "")
            {
                MessageBox.Show("PLease!Enter the Address ", "ADDRESS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_address.Focus();
                txt_address.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txt_address.BackColor = Color.White;
            }
            if (txt_city.Text == "")
            {
                MessageBox.Show("PLease!Enter the City Name", "CITY ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_city.Focus();
                txt_city.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txt_city.BackColor = Color.White;
            }
            if (rdb_muslim.Checked == false && rdb_non_muslim.Checked == false)
            {
                MessageBox.Show("Please! Select the Religion", "RELIGION SELECTION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rdb_muslim.ForeColor = Color.Red;
                rdb_non_muslim.ForeColor = Color.Red;
                return false;
            }
            else
            {
                if (rdb_muslim.Checked == true)
                {
                    rdb_muslim.ForeColor = Color.LightGreen;
                    rdb_non_muslim.ForeColor = Color.LightPink;

                }
                else
                {
                    rdb_non_muslim.ForeColor = Color.LightGreen;
                    rdb_muslim.ForeColor = Color.LightPink;
                }

            }

            return true;
        }

        //City and branch
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (Control_Validate() == true)
            {
                string cs = ConfigurationManager.ConnectionStrings["StudentRecordDBConnectionString"].ConnectionString;
                SqlConnection objSqlConnection = new SqlConnection(cs);
                try
                {
                    Check_Control();
                    objSqlConnection.Open();
                    string InsertCommand = "INSERT INTO tblStudentRecord VALUES(" + Convert.ToInt32(txt_stdRoll.Text) + ",'" + txt_FirstNm.Text + "','" +
                        txt_LastNm.Text + "','" + txt_GuardianNm.Text + "','" + gender + "','" +
                        dob.Value.ToString("MM/dd/yyyy") + "','"+txt_address.Text+"','"+txt_phoneNo.Text+
                        "','"+txt_city.Text+"','"+cmb_branch.SelectedItem.ToString()+"','"+religion+"')";

                    SqlCommand ObjSqlCommand = new SqlCommand(InsertCommand,objSqlConnection);
                    ObjSqlCommand.ExecuteNonQuery();
                    // TODO: This line of code loads data into the 'studentRecordDBDataSet.tblStudentRecord' table. You can move, or remove it, as needed.
                    this.tblStudentRecordTableAdapter.Fill(this.studentRecordDBDataSet.tblStudentRecord);

                    MessageBox.Show("Student of ROLL NO" + txt_stdRoll.Text + "is successfully Added", "INSERTION SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error occured in Insertion of Roll No" + txt_stdRoll.Text +ex.Message, "ERROR OCCURED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objSqlConnection.Close();
                }
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            string cs = ConfigurationManager.ConnectionStrings["StudentRecordDBConnectionString"].ConnectionString;
            SqlConnection objSqlConnection = new SqlConnection(cs);
            try
            {
                Check_Control();
                objSqlConnection.Open();
                string DeleteCommand = "DELETE FROM tblStudentRecord WHERE StudentRollNo="+txt_stdRoll.Text+"";
                SqlCommand ObjSqlCommand = new SqlCommand(DeleteCommand, objSqlConnection);
                ObjSqlCommand.ExecuteNonQuery();
                // TODO: This line of code loads data into the 'studentRecordDBDataSet.tblStudentRecord' table. You can move, or remove it, as needed.
                this.tblStudentRecordTableAdapter.Fill(this.studentRecordDBDataSet.tblStudentRecord);

                MessageBox.Show("Student of ROLL NO" + txt_stdRoll.Text + "is successfully Deleted", "DELETION SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured in Deletion of Roll No" + txt_stdRoll.Text + ex.Message, "ERROR OCCURED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(Control_Validate())
            {
                string cs = ConfigurationManager.ConnectionStrings["StudentRecordDBConnectionString"].ConnectionString;
                SqlConnection ObjSqlConnection = new SqlConnection(cs);
                try
                {
                    ObjSqlConnection.Open();
                    string UpdateCommand = "UPDATE tblStudentRecord SET FirstName='" + this.txt_FirstNm.Text +
                        "',LastName='"+this.txt_LastNm.Text+"',GuardianName='"+this.txt_GuardianNm.Text+
                        "',Gender='"+this.gender+"',DateOfBirth='"+this.dob.Value.ToString("dd/MM/yyyy")+
                        "',PhoneNumber='"+txt_phoneNo.Text+"',Address='"+txt_address.Text+"',City='"+
                        txt_city.Text+"',Branch='"+cmb_branch.SelectedItem.ToString()+"',Religion='"+
                        religion+"' WHERE StudentRollNo="+txt_stdRoll.Text+"";
                    SqlCommand ObjSqlCommand = new SqlCommand(UpdateCommand, ObjSqlConnection);
                    ObjSqlCommand.ExecuteNonQuery();
                    // TODO: This line of code loads data into the 'studentRecordDBDataSet.tblStudentRecord' table. You can move, or remove it, as needed.
                    this.tblStudentRecordTableAdapter.Fill(this.studentRecordDBDataSet.tblStudentRecord);

                    MessageBox.Show("Student of ROLL NO" + txt_stdRoll.Text + "is successfully Updated", "UPDATION SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_control();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured of Roll No" + txt_stdRoll.Text, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ObjSqlConnection.Close();
                }
            }
        }

                private void btn_reset_Click(object sender, EventArgs e)
        {

            Clear_control();

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Preview_form ObjPreviewForm = new Preview_form();
            Check_Control();
            ObjPreviewForm.PreviewStudent(Convert.ToInt32(txt_stdRoll.Text),txt_FirstNm.Text,txt_LastNm.Text,
                txt_GuardianNm.Text,gender,dob.Text,txt_phoneNo.Text,txt_address.Text,
                txt_city.Text,cmb_branch.SelectedItem.ToString(),religion);
            ObjPreviewForm.ShowDialog();




        }
        //Implicit function
        bool OnlyNumAndSpace;
        private void txt_stdRoll_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumAndSpace = false;
            if(char.IsNumber(e.KeyChar)|| e.KeyChar==8)
            {
                OnlyNumAndSpace = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_phoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar)|| e.KeyChar==8)
            {
                OnlyNumAndSpace = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmb_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentRecordDBDataSet.tblStudentRecord' table. You can move, or remove it, as needed.
            this.tblStudentRecordTableAdapter.Fill(this.studentRecordDBDataSet.tblStudentRecord);

        }
        //City and Branch Selection
        private void txt_city_TextChanged(object sender, EventArgs e)
        {
            if(txt_city.Text=="karachi" || txt_city.Text=="Karachi")
            {
                cmb_branch.Items.Clear();
                cmb_branch.Items.Add("Shamsi School,Near Airport,Branch I");
                cmb_branch.Items.Add("Shamsi School,North Nazimabad,Phase II");
                cmb_branch.Items.Add("Shamsi School,Gulshan Branch III");
            }
            else if(txt_city.Text=="lahore" || txt_city.Text=="Lahore")
            {
                cmb_branch.Items.Clear();
                cmb_branch.Items.Add("Nasra School,Gawal Mandhi");
                cmb_branch.Items.Add("Nasra School,Purana Lahore");
            }
            else if(txt_city.Text=="islamabad" || txt_city.Text=="Islamabad")
            {
                cmb_branch.Items.Clear();
                cmb_branch.Items.Add("City School,Burger Branch 1");
                cmb_branch.Items.Add("City School,Burger Branch 2");
            }

           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_stdRoll.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txt_FirstNm.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txt_LastNm.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txt_GuardianNm.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            gender = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            dob.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            txt_address.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            txt_phoneNo.Text = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
            txt_city.Text = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            cmb_branch.Text= dataGridView1.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            religion = dataGridView1.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();

            if(gender=="Male")
            {
                rdb_male.Checked = true;
            }
            else
            {
                rdb_female.Checked = true;
            }

            if(religion=="Muslim")
            {
                rdb_muslim.Checked = true;
            }
            else
            {
                rdb_non_muslim.Checked = true;
            }
        }
    }
}
