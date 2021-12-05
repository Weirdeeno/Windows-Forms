using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Singleton
        public static Form1 Instance { get; private set; }


        private List<Student> _students = new List<Student>();
        private TeacherList teacherList = new TeacherList();

        public List<Student> Students { get { return _students; } }
        public TeacherList Teachers { get { return teacherList; } }

        public Form1()
        {
            // Init singleton
            Instance = this;

            // Init the thing
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Initial1()
        {
            InitialTeachersSetup();
            DataTable table1 = new DataTable();
            table1.Columns.Add("Имя");
            table1.Columns.Add("Фамилия");
            table1.Columns.Add("Возраст");
            table1.Columns.Add("Пол");
            table1.Columns.Add("Дисциплина");
            table1.Columns.Add("Курс");
            table1.Columns.Add("Страна");
            table1.Columns.Add("Город");
            table1.Columns.Add("Улица");
            table1.Columns.Add("Номер дома");
            
          

            int i;
            for (i = 0; i < teacherList.Teachers.Count; i++)
            {

                Teacher teacher = teacherList.Teachers[i];
                table1.Rows.Add(teacher._name, teacher._surname, teacher._age, teacher.Sex, teacher._discipline, teacher._cоurse_number, teacher.address._country, teacher.address._city, teacher.address._street, teacher.address._house_number);

            }
            this.dataGridView1.DataSource = table1;

        }

        public void Initial2()
        {
            InitialTeachersSetup();
            DataTable table2 = new DataTable();
            table2.Columns.Add("Имя");
            table2.Columns.Add("Фамилия");
            table2.Columns.Add("Возраст");
            table2.Columns.Add("Пол");
            table2.Columns.Add("Группа");
            table2.Columns.Add("Факультет");
            table2.Columns.Add("Страна");
            table2.Columns.Add("Город");
            table2.Columns.Add("Улица");
            table2.Columns.Add("Номер дома");



            int i;
            for (i = 0; i < _students.Count; i++)
            {

                Student student = _students[i];
                table2.Rows.Add(student._name, student._surname, student._age, student.Sex, student._group, student._faculty, student.address._country, student.address._city, student.address._street, student.address._house_number);

            }
            this.dataGridView2.DataSource = table2;
        }

            private void InitialTeachersSetup()
        {
            if (teacherList.Teachers.Count == 0)
            {
                teacherList.AddTeacher(new Teacher(new Address("Украина", "Херсон", "Патона", 5), "Виталий", "Ломоносов", 35, "М", "Педагогика", 3));
                teacherList.AddTeacher(new Teacher(new Address("Украина", "Херсон", "Поковника Кедровского", 10), "Владислав", "Морозов", 23, "М", "Художественное исскуство", 2));
                teacherList.AddTeacher(new Teacher(new Address("Украина", "Херсон", "Чорноморская", 27), "Екатерина", "Ликова", 27, "Ж", "Математический анализ", 1));
                teacherList.AddTeacher(new Teacher(new Address("Украина", "Херсон", "Кулика", 17), "Тома", "Федоровна", 65, "Ж", "Психология", 2));
                teacherList.AddTeacher(new Teacher(new Address("Украина", "Херсон", "Перекопская", 34), "Данна", "Новикова", 55, "Ж", "Дискретная математика", 1));
                teacherList.AddTeacher(new Teacher(new Address("Украина", "Херсон", "Ушакова", 56), "Ярослав", "Смирнов", 28, "M", "База данных", 3));
            }

            if (_students.Count == 0)
            {
                _students.Add(new Student("Евгений", "Палков", 20, "М", 331, "ФКНФМ", new Address("Украина", "Херсон", "Суворова", 4), Mark.B));
                _students.Add(new Student("Валерия", "Букало", 19, "Ж", 261, "ФКНФМ", new Address("Украина", "Херсон", "Университетская", 13), Mark.A));
                _students.Add(new Student("Антон", "Мероков", 16, "М", 141, "ФКНФМ", new Address("Украина", "Геническ", "Школьная", 33), Mark.A));
                _students.Add(new Student("Валерий", "Шмык", 17, "М", 111, "ФКНФМ", new Address("Украина", "Догмаровка", "Молодежная", 5), Mark.A));
                _students.Add(new Student("Ксения", "Хофман", 21, "Ж", 432, "ФКНФМ", new Address("Украина", "Алешки", "Стритенская", 68), Mark.A));
                _students.Add(new Student("Денис", "Строймак", 18, "М", 221, "ФКНФМ", new Address("Украина", "Херсон", "Мира", 17), Mark.A));

            }
        }

        public void UpdateContent()
        {
            Initial1();
            Chart1();
            Chart2();
            InitialTreeView();
            Initial2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateContent();
        }

        private void Chart1()
        {
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < teacherList.Teachers.Count; i++)
            {
                this.chart1.Series["Возраст"].Points.AddXY(teacherList.Teachers[i]._name, teacherList.Teachers[i]._age);
            }
        }

        private void Chart2()
        {
            chart2.Series[0].Points.Clear();
            for (int i = 0; i < _students.Count; i++)
            {
                this.chart2.Series["Возраст"].Points.AddXY(_students[i]._name, _students[i]._age);
            }
        }

        public void InitialTreeView()
        {
            treeView1.Nodes.Clear();

            foreach (Teacher teacher in teacherList.Teachers)
            {
                // Setup teacher info
                TreeNode currentTeacher = treeView1.Nodes.Add(teacher._surname, teacher._surname, teacher._discipline);
                currentTeacher.Nodes.Add(teacher._name);
                currentTeacher.Nodes.Add(Convert.ToString(teacher._age));
                currentTeacher.Nodes.Add(Convert.ToString(teacher.Sex));
                currentTeacher.Nodes.Add(Convert.ToString(teacher._discipline));

                // Setup teachers' address
                var address = currentTeacher.Nodes.Add("Address", "Адрес");
                address.Nodes.Add(teacher.address._country);
                address.Nodes.Add(teacher.address._city);
                address.Nodes.Add(teacher.address._street);
                address.Nodes.Add(Convert.ToString(teacher.address._house_number));


                // Setup teachers students
                var students = currentTeacher.Nodes.Add("Students", "Студенты");
                foreach (Student student in _students)
                {
                    // Add student info
                    var currentStudent = students.Nodes.Add(student._surname, student._surname);
                    currentStudent.Nodes.Add(student._name);
                    currentStudent.Nodes.Add(Convert.ToString(student._age));
                    currentStudent.Nodes.Add(Convert.ToString(student.Sex));

                    // Setup student address
                    var studentAddress = currentStudent.Nodes.Add("Адрес");
                    studentAddress.Nodes.Add(student.address._country);
                    studentAddress.Nodes.Add(student.address._city);
                    studentAddress.Nodes.Add(student.address._street);
                    studentAddress.Nodes.Add(Convert.ToString(student.address._house_number));
                }
            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}