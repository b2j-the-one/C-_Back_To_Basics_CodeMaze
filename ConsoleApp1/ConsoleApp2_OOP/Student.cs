namespace ConsoleApp2_OOP
{
    public class Student
    {
        private string _name;
        private string _lastName;

        public string Name  // public string Name { get; set };
        {
            get { return _name; }
            set { _name = value; }
        }
        /*{
            get => _name;
            set => _name = value;
        }*/


        public string LastName // public string LastName { get; set };
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        /*{
            get => _lastName;
            set => _lastName = value;
        }*/

    public Student(string name, string lastName)
        {
            _name = name;
            _lastName = lastName;
        }

        public string GetFullName() // public string FullName => $"{_name} {_lastName}";
        {
            return _name + " " + _lastName;
        }
    }

    /*partial class Student
    {
        private string _name;
        private string _lastName;

        public Student()
        {
            _name = string.Empty;
            _lastName = string.Empty;
        }
    }

    partial class Student
    {
        public Student(string name, string lastName)
        {
            _name = name;
            _lastName = lastName;
        }

        public string GetFullName()
        {
            return _name + " " + _lastName;
        }
    }*/
}
