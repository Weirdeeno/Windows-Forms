using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }


        private void AddTeacher(string sn, string ssur, int sage, string sex, string discipline, int ccourse_number, string ccountry, string ccity, string sstreet, int hn)
        {
            sn = TeacherName.Text;
            ssur = TeacherSurname.Text;
            string input = TeacherAge.Text;
            sex = TeacherSex.Text;
            string disciplinet = TeacherDiscipline.Text;
            string input1 = TeacherCourse_Number.Text;
            var parseResult = int.TryParse(input, out sage);
            var parseResult1 = int.TryParse(input1, out ccourse_number);
            ccountry = TeacherAddressCountry.Text;
            ccity = TeacherAddressCity.Text;
            sstreet = TeacherAddressStreet.Text;
            string input2 = TeacherAddressHouse_Number.Text;
            var pasteResult2 = int.TryParse(input2, out hn);
        }



        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            string n = TeacherName.Text;
            string sur = TeacherSurname.Text;
            int age = 0;
            string input = TeacherAge.Text;
            string sex = TeacherSex.Text;
            string discipline = TeacherDiscipline.Text;
            var parseResult = int.TryParse(input, out age);
            int course_number = 0;
            string input1 = TeacherCourse_Number.Text;
            var parseResult1 = int.TryParse(input1, out course_number);
            string country = TeacherAddressCountry.Text;
            string city = TeacherAddressCity.Text;
            string street = TeacherAddressStreet.Text;
            int house_number = 0;
            string input2 = TeacherAddressHouse_Number.Text;
            var parseResult2 = int.TryParse(input2, out house_number);
            Form1.Instance.Teachers.AddTeacher(new Teacher(new Address(country, city, street, house_number), n, sur, age, sex, discipline, course_number));
            Form1.Instance.UpdateContent();
        }

        private void TeacherSex_TextChanged(object sender, EventArgs e)
        {

        }
    }
}