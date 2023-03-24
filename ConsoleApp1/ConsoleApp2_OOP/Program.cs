using ConsoleApp2_OOP;

Student student = new Student("Borgeah", "Atwood");

string name = student.Name;
string lastName = student.LastName;

student.Name = "Ashta";
student.LastName = "Austalie";
Console.WriteLine(student.GetFullName());
