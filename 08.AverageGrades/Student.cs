using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AverageGrades
{
    class Student
    {
        public string Name;
        public List<double> Grades = new List<double>();
        public double AverageGrade;

        public Student(string name, double[] grades)
        {
            Name = name;
            Grades = grades.ToList();
            AverageGrade = Math.Round(grades.Average(), 2);
        }
    }
}
