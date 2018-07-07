namespace AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public string Name { set; get; }
        public List<double> Grades { set; get; }
        
        public double AverageGrade
        {
            get {
                    return Grades.Average();
                }
        
        }   
    }
}
