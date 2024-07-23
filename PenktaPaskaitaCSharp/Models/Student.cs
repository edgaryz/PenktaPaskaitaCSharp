namespace PenktaPaskaitaCSharp.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int[] Grades { get; set; }
        int lastAdded = 0;
        int gradeCount = 0;

        public Student()
        {
            Grades = new int[100];
        }
        public Student(string name, string surName)
        {
            Name = name;
            SurName = surName;
        }

        public Student(string name, string surName, int[] grades)
        {
            Name = name;
            SurName = surName;
            Grades = grades;
        }

        public void AddGrade(int grade)
        {
            Grades[lastAdded] = grade;
            lastAdded++;
            gradeCount++;
        }

        public double AverageGrade(int[] grades)
        {
            double averageGrade = 0;
            foreach (int grade in grades)
            {
                averageGrade += grade;
            }

            return averageGrade / grades.Length;
        }

        public override string ToString() {
            return $"Studentas/ė {Name} {SurName}, vidutinis pažymis {AverageGrade(Grades)}.";
        }
    }
}
