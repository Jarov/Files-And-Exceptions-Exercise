using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace _08.AverageGrades
{
    class AverageGrades
    {
        static void Main()
        {
            string[] inPut = File.ReadAllLines(@"..\..\inPut.txt");
            int numberOfStudents = int.Parse(inPut.First());

            List<Student> students = new List<Student>();
            
            for (int index = 1; index < inPut.Length; index++)
            {
                string[] currentStudent = inPut[index].Split(' ');

                Student student = new Student(currentStudent[0], Grades(currentStudent));

                if (student.AverageGrade >= 5.00)
                    students.Add(student);
            }

            SortAndPrint(students);
        }

        static double[] Grades(string[] currentStudent)
        {
            double[] grades = new double[currentStudent.Length - 1];

            for (int insertGrade = 0; insertGrade < grades.Length; insertGrade++)
            {
                grades[insertGrade] = double.Parse(currentStudent[insertGrade + 1]);
            }
            return grades;
        }

        static void SortAndPrint(List<Student> Students)
        {
            IOrderedEnumerable<Student> sortedStudents = Students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade);
            string[] result = new string[sortedStudents.Count()];

            int resultIndex = 0;
            foreach (Student student in sortedStudents)
            {
                result[resultIndex] = $"{student.Name} -> {student.AverageGrade}";
                resultIndex++;
            }

            File.WriteAllLines(@"..\..\outPut.txt", result);
        }
    }
}
