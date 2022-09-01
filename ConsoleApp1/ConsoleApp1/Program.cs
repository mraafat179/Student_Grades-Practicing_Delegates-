using System;

namespace Event
{
    public class Student
    {
        public string studentName { get; set; }
        public string schoolName { get; set; }
        public int studentScore { get; set; }
    }
    public class Program
    {
        public delegate bool grades(Student stu);
        static void Main(string[] args)
        {
            string student_name,school_name;
            int student_score;
            List<Student> studentsList = new List<Student>();
            Console.Write("Enter the number of students : ");
            int numOfStudents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for(int index = 0; index < numOfStudents; index++)
            {
                Console.Write("Enter Student number [{0}] Name : ", index + 1);
                student_name = Console.ReadLine();
                Console.Write("Enter Student number [{0}] School Name : ",index+1);
                school_name = Console.ReadLine();
                Console.Write("Enter Student number [{0}] Student Score : ",index + 1);
                student_score = Convert.ToInt32(Console.ReadLine());
                Student s = new Student
                {
                    studentName = student_name,
                    schoolName = school_name,
                    studentScore = student_score
                };
                studentsList.Add(s);
                Console.WriteLine();

            }
            Console.WriteLine();
     
            gradesStudentsList("Students with grade A", studentsList, gradeA);
            gradesStudentsList("Students with grade B", studentsList, gradeB);
            gradesStudentsList("Students with grade C", studentsList, gradeC);
            gradesStudentsList("Students with grade D", studentsList, gradeD);
            gradesStudentsList("Students with grade F", studentsList, gradeF);
        }

       public static void gradesStudentsList(string title,List<Student> students,grades grade)
       {
            
            int Empty = 0;
            foreach (Student s in students)
            {
                if (!grade(s))
                {
                    Empty++;
                }
            }
            if(Empty!=students.Count)
            {
                Console.WriteLine();
                Console.WriteLine("-----" + title + "-----");
                Console.WriteLine();
                foreach (Student s in students)
                {
                    if (grade(s))
                    {
                        Console.WriteLine("Student Name : {0}       School Name : {1} ", s.studentName, s.schoolName);
                    }
                }
                Console.WriteLine();
            }
            
            
        }

        public static bool gradeA(Student s)
        {
            if (s.studentScore >= 85)
                return true;
            return false ;
        }
        public static bool gradeB(Student s)
        {
            if (s.studentScore >= 75 && s.studentScore < 85)
                return true;
            return false;
        }
        public static bool gradeC(Student s)
        {
            if (s.studentScore >= 65 && s.studentScore < 75)
                return true;
            return false;
        }
        public static bool gradeD(Student s)
        {
            if (s.studentScore >= 50 && s.studentScore < 65)
                return true;
            return false;
        }
        public static bool gradeF(Student s)
        {
            if (s.studentScore < 50)
                return true;
            return false;
        }
    } 
}
