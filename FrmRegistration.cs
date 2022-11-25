using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingFrmRegistration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            long getStudNum = Convert.ToInt64(txtStudNum.Text);
            string getLastName = txtLastName.Text;
            string getFirstName = txtFirstName.Text;
            string getMiddleName = txtMiddleName.Text;
            String getProgram = cbProgram.Text;
            int getAge = Convert.ToInt32(txtAge.Text);
            string getGender = cbGender.Text;
            long getContactNum = Convert.ToInt64(txtContactNum.Text);
            string getBirthday = DTPbirthday.Text;

            string docPath =
Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName.SetFileName)))
            {
                outputFile.WriteLine("Student No.: "+getStudNum);
                Console.WriteLine(getStudNum);
                outputFile.WriteLine("Full Name.: " + getLastName+", "+getFirstName+", "+getMiddleName);
                Console.WriteLine("Full Name.: " + getLastName + ", " + getFirstName + ", " + getMiddleName);
                outputFile.WriteLine("Program: "+getProgram);
                Console.WriteLine("Program: " + getProgram);
                outputFile.WriteLine("Gender: " + getGender);
                Console.WriteLine("Gender: " + getGender);
                outputFile.WriteLine("Age: " + getAge);
                Console.WriteLine("Age: " + getAge);
                outputFile.WriteLine("Birthday: " + getBirthday);
                Console.WriteLine("Birthday: " + getBirthday);
                outputFile.WriteLine("Contact No.: " + getContactNum);
                Console.WriteLine("Contact No.: " + getContactNum);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmStudentRecord frmStudentRecord = new FrmStudentRecord();
            frmStudentRecord.ShowDialog();
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.Close();
        }
    }
}
