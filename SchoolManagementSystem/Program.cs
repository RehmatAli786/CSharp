namespace SchoolManagementSystem
{
    public static class School
    {
        public const string SchoolName = "Rahmani School";
        public static int totalTeacher;
        public static int totalStudent;
    }
    public class Person
    {
        public string name = String.Empty;
        public int age;
    }

    public class Teacher : Person
    {
        public readonly int employeeId;
        public string subject = String.Empty;
        public decimal salary;

        public Teacher(int employeeId, string name, int age, string subject, decimal salary)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.age = age;
            this.subject = subject;
            this.salary = salary;

            School.totalTeacher ++;
        }
    }

    public class Student : Person
    {
        public readonly int studentId;
        public string course = String.Empty;
        public char grade;

        public Student(int studentId, string name, int age, string course, char grade)
        {
            this.studentId = studentId;
            this.name = name;
            this.age = age;
            this.course = course;
            this.grade = grade;

            School.totalStudent ++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher firstTeacher = new(1001, "Ahmed Hassan", 32, "Artificial Intelligence", 100000.00m);
            Teacher secondTeacher = new(1002, "Muhammad Hussain", 30, "Software Engineering", 90000.00m);
            Teacher thirdTeacher = new(1004, "Arif Rozi", 35, "Deep Learning", 130000.00m);

            Student firstStudent = new(2001, "Kacho Ali", 22, "Deep Learning", 'A');
            Student secondStudent = new(2002, "Hassan Ali", 21, "Deep Learning", 'B');
            Student thirdStudent = new(2003, "Rehan Ali", 23, "Deep Learning", 'C');

            Console.WriteLine($"======================= {School.SchoolName} ========================\n" +
                              $"Total Teacher at School: {School.totalTeacher}\n" +
                              $"Total Student at School: {School.totalStudent}\n\n" +
                              $"====================== Highest Salay Paid Teacher ==================\n" +
                              $"EmployeeId: {thirdTeacher.employeeId}\n" +
                              $"Name: {thirdTeacher.name}\n" +
                              $"Age: {thirdTeacher.age}\n" +
                              $"Salary: {thirdTeacher.salary}\n\n" +
                              $"====================== Highest Grade Student ==================\n" +
                              $"EmployeeId: {firstStudent.studentId}\n" +
                              $"Name: {firstStudent.name}\n" +
                              $"Age: {firstStudent.age}\n" +
                              $"Salary: {firstStudent.grade}");
        }
    }
}
