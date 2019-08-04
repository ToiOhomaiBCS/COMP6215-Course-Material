using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(10023443, "Bart", "Simpson", Role.Student);
            person1.Email = EMail.CreateEmail(person1);

            Console.WriteLine($"My name is {person1.FName} and my email is {person1.Email}");

            Person person2 = new Person(2345, "Seymour", "Skinner", Role.Teacher);
            person2.Email = EMail.CreateEmail(person2);

            Console.WriteLine($"My name is {person2.FName} and my email is {person2.Email}");
        }
    }

    class Teacher : IPerson
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public Role role { get; set; }

        public Teacher(int i, string f, string l, Role r)
        {
            Id = i;
            FName = f;
            LName = l;
            Role = r;
        }

        public string Email()
        {
            return $"{FName}.{LName}@springfield.edu";
        }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public Role role { get; set; }

        public Student(int i, string f, string l, Role r)
        {
            Id = i;
            FName = f;
            LName = l;
            Role = r;
        }

        public string Email()
        {
            $"{Id}@student.springfield.edu";
        }
    }

    class EMail
    {
        public static string CreateEmail(Person person)
        {
            string output = "";

            if(person.role == Role.Student)
            {
                output = $"{person.Id}@student.springfield.edu";
            }
            else if (person.role == Role.Teacher)
            {
                output = $"{person.FName}.{person.LName}@springfield.edu";
            }

            return output;
        }
    }

    enum Role
    {
        Teacher,
        Student
    }
}
