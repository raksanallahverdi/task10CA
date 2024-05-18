using System;
namespace Task7
{


    public static class Program
    {
        public static void Main()
        {
            Student student = new Student("Raksana", "Allahverdiyeva");
            Teacher teacher1 = new Teacher("Kanan", "Tapdiqli");
            Teacher teacher2 = new Teacher("Ali", "Tapdiqli");
            Subject math = new Subject("Math", "Good");
            Group Pb401 = new Group(401,12, new DateTime(2024,12,23), new DateTime(2025,2,25));
            Pb401.AddSubject(math);
            Pb401.AddStudent(student);
            Pb401.AddTeacher(teacher1);
            Pb401.AddTeacher(teacher2);
            Pb401.RemoveTeachers(teacher1);
            Pb401.GetTeachers();
            Pb401.GetSubjects();
            Pb401.GetDetails();


        }
    }
}

