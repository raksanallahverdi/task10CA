using System;
namespace Task7
{
	public class Group

	{
        public int GroupNo { get; set; }
        public int Limit { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        private Student[] students;
        public Student[] Students { get => students; }
        private Teacher[] teachers;
        public Teacher[] Teacher { get => teachers; }
        private Subject[] subjects;
        public Subject[] Subject { get => subjects; }




        public Group(int groupNo,int limit, DateTime startDate,DateTime endDate)
		{
            
            GroupNo = groupNo;
            Limit = limit;
            EndDate = endDate;
            StartDate = startDate;
            

            students = new Student[0];
            teachers = new Teacher[0];
            subjects = new Subject[0];

        }

        public void AddStudent(Student student)
        {
            if (Students.Length < Limit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Group is at maximum capacity. Can not add more students.");
            }

        }

        public void GetStudents()
        {
            foreach (var item in students)
            {
                item.GetDetails();
            }

        }
        public void RemoveStudents(Student student)
        {
            
            int index = Array.IndexOf(students, student);
            if (index != -1)
            {
                for (int i = index; i < students.Length - 1; i++)
                {
                    students[i] = students[i + 1];
                }
                Array.Resize(ref students, students.Length - 1);

            }
            else
            {
                Console.WriteLine("bele studentimiz yoxdu");
            }

            

        }

        public void AddTeacher(Teacher teacher)
        {
            if (teachers.Length < Limit)
            {
                Array.Resize(ref teachers, teachers.Length + 1);
                teachers[teachers.Length - 1] = teacher;
            }
            else
            {
                Console.WriteLine("Group is at maximum capacity. Can not add more teachers.");
            }
        }

        public void RemoveTeachers(Teacher teacher)
        {

            int index = Array.IndexOf(teachers, teacher);
            if (index != -1)
            {
                for (int i = index; i < teachers.Length - 1; i++)
                {
                    teachers[i] = teachers[i + 1];
                }
                Array.Resize(ref teachers, teachers.Length - 1);

            }
            else
            {
                Console.WriteLine("bele teacherimiz yoxdu");
            }




        }
        public void GetTeachers()
        {
            foreach (var item in teachers)
            {
                item.GetDetails();
            }

        }


        public void AddSubject(Subject subject)
        {
            if (subjects.Length < Limit)
            {
                Array.Resize(ref subjects, subjects.Length + 1);
                subjects[subjects.Length - 1] = subject;
            }
            else
            {
                Console.WriteLine("Group is at maximum capacity. Can not add more subjects.");
            }
        }

        public void RemoveSubject(Subject subject)
        {

            int index = Array.IndexOf(subjects, subject);
            if (index != -1)
            {
                for (int i = index; i < subjects.Length - 1; i++)
                {
                    subjects[i] = subjects[i + 1];
                }
                Array.Resize(ref subjects, subjects.Length - 1);

            }
            else
            {
                Console.WriteLine("bele subjectimiz yoxdu");
            }




        }
        public void GetSubjects()
        {
            foreach (var item in subjects)
            {
                item.GetDetails();
            }

        }

        public void GetDetails()
        {
            Console.WriteLine($"Group Number: {GroupNo} Group limit: {Limit} Start Date: {StartDate.ToShortDateString()} End Date: {EndDate.ToShortDateString()}");
        }
    }
}

