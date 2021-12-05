using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void AddStudent(string sn, string ssur, int sage, string ssex, int ggroup, string ffaculty, string ccountry, string ccity, string sstreet, int hn)
        {
            sn = StudentName.Text;
            ssur = StudentSurname.Text;
            ssex = StudentSex.Text;
            ffaculty = StudentFaculty.Text;
            ccountry = StudentAddressCountry.Text;
            ccity = StudentAddressCity.Text;
            sstreet = StudentAddressStreet.Text;

            string inputAge = StudentAge.Text;
            var parseResultAge = int.TryParse(inputAge, out sage);
            string inputGroup = StudentGroup.Text;
            var parseResultGroup = int.TryParse(inputGroup, out ggroup);
            string inputHouseNumber = StudentAddressHouseNumber.Text;
            var parseResultHouseNumber = int.TryParse(inputHouseNumber, out hn);
        }

        private void AddStudentButton_Click_Click(object sender, EventArgs e)
        {
                string n = StudentName.Text;
                string sur = StudentSurname.Text;
                string sex = StudentSex.Text;
                string faculty = StudentFaculty.Text;
                string country = StudentAddressCountry.Text;
                string city = StudentAddressCity.Text;
                string street = StudentAddressStreet.Text;

                int age = 0;
                string inputAge = StudentAge.Text;
                var parseResultAge = int.TryParse(inputAge, out age);
                int group = 0;
                string inputGroup = StudentGroup.Text;
                var parseResultGroup = int.TryParse(inputGroup, out group);
                int house_number = 0;
                string inputHouseNumber = StudentAddressHouseNumber.Text;
                var parseResultHouseNumber = int.TryParse(inputHouseNumber, out house_number);

                Form1.Instance.Students.Add(new Student(n, sur, age, sex, group, faculty, new Address(country, city, street, house_number), Mark.A));
                Form1.Instance.UpdateContent();
            }
        }
    }

