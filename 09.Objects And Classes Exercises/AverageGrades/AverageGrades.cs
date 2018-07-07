using System;
using System.Collections.Generic;
using System.Linq;


namespace AverageGrades
{
    class AverageGrades
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> Students = new List<Student>();



            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ').ToArray();

                List<double> GradesList = new List<double>();
                string studentName = input[0];

                for (int j = 1; j < input.Length; j++)
                {

                    double grades = double.Parse(input[j]);
                    if (grades > 6)
                        grades = grades / 100;

                    GradesList.Add(grades);
                }

                Student student = new Student();
                student.Name = studentName;
                student.Grades = GradesList;

                Students.Add(student);
            }

            foreach (var student1 in Students
                .Where(s => s.AverageGrade >= 5)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade))
            {
                Console.WriteLine("{0} -> {1:f2}", student1.Name, student1.AverageGrade);
            }
        }
    }
}
