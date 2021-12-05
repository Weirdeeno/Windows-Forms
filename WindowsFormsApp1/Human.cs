namespace WindowsFormsApp1
{
    public enum Sex
    {
        Male,
        Female
    }
    public class Human
    {

        public Address address;
        public string _name;
        public string _surname;
        public int _age;
        public string Sex;

        public Human(string name, string surname, int age, string sex, Address addres)
        {
            _name = name;
            _surname = surname;
            _age = age;
            Sex = sex;
            address = addres;
        }


    }
}