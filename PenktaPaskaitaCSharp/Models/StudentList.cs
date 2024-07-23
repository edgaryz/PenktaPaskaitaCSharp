namespace PenktaPaskaitaCSharp.Models
{
    public class StudentList
    {
        public Student[] Students { get; set; }
        int lastAdded = 0;
        int studentCount = 0;
        public StudentList()
        {
            Students = new Student[100];
        }

        public void AddStudent(Student student)
        {
            Students[lastAdded] = student;
            lastAdded++;
            studentCount++;
        }

        public void RemoveStudentByNameAndSurName(string name, string surName)
        {
            for (int i = 0; i < studentCount; i++)
            {
                if (Students[i].Name == name && Students[i].SurName == surName)
                {
                    for (int j = i; j < studentCount - 1; j++)
                    {
                        Students[j] = Students[j + 1];
                    }
                    Students[studentCount - 1] = null;
                    studentCount--;
                    break;
                }
            }
        }

        public Student FindStudentByNameAndSurName(string name, string surName)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Name == name && Students[i].SurName == surName)
                {
                    return Students[i];
                }
            }
            return null;
        }

        public double AverageGradeOfStudents()
        {
            double overAllAverageGradeSum = 0;
            foreach (Student student in Students)
            {
                if (student == null)
                {
                    break;
                }
                overAllAverageGradeSum += student.AverageGrade(student.Grades);
            }
            return overAllAverageGradeSum/studentCount;
        }

        public override string ToString()
        {
            return $"Studentų sąrašas: {Students}";
        }
    }
}
