using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class TeacherList
    {
        public List<Teacher> _teachers;

        public TeacherList()
        {
            _teachers = new List<Teacher>();
        }

        public List<Teacher> Teachers
        {
            get
            {
                return _teachers;
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (_teachers.Contains(teacher))
            {
                _teachers.Remove(teacher);
            }
        }


    }
}