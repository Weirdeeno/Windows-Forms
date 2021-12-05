namespace WindowsFormsApp1
{

    
    public class Student : Human
    {
        public int _group;
        public string _faculty;
        public Mark mark;

        public Student(string name, string surname, int age, string sex, int group, string faculty, Address adress, Mark _mark)
            : base(name, surname, age, sex, adress)
        {
            _group = group;
            _faculty = faculty;
            _mark = mark;
        }

        public int group { get; set; }
        public char faculty { get; set; }
        public Mark _mark { get; set; }



    }
}