using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public enum Mark
    {
        F = 1,
        D = 2,
        C = 3,
        B = 4,
        A = 5,
    }

    public class Teacher : Human
    {
        public string _discipline;
        public int _cоurse_number;

        public List<Student> _students = new List<Student>();

        public Teacher(Address adress, string name, string surname, int age, string sex, string discipline, int course_number)
            : base(name, surname, age, sex, adress)
        {
            _discipline = discipline;
            _cоurse_number = course_number;
            _students = new List<Student>(13);
        }
        private string discipline { get; }
        private int course_number { get; }
        public List<Student> Students
        {
            get
            {
                return _students;
            }
        }
        public void RegisterStudent(Student student)
        {
            _students.Add(student);

        }

        public void UnregisterStudent(Student student)
        {
            if (_students.Contains(student))
            {
                _students.Remove(student);
            }
        }
    }
}