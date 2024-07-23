using PenktaPaskaitaCSharp.Models;

namespace MyProgram
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            /*Task 1*/
            Console.WriteLine("TASK 1");
            Console.WriteLine("ADD ITEMS");
            ItemCart cart = new ItemCart();
            cart.AddItem(new Item("Carrot", 6, 0.09));
            cart.AddItem(new Item("Shrooms", 20, 0.1));
            cart.AddItem(new Item("Vine", 1, 6.99));
            cart.AddItem(new Item("Rice", 2, 0.69));
            cart.AddItem(new Item("Fish", 2, 1.45));

            foreach (Item item in cart.Items)
            {
                if (item == null)
                {
                    break;
                }
                Console.WriteLine(item);
            }

            Console.WriteLine("REMOVE ITEMS");
            cart.RemoveItem("Shrooms");

            foreach (Item item in cart.Items)
            {
                if (item == null)
                {
                    break;
                }
                Console.WriteLine(item);
            }

            Console.WriteLine("TOTAL PRICE");
            Console.WriteLine(cart.TotalPrice(cart.Items));

            Console.WriteLine("FIND ITEMS");
            Console.WriteLine(cart.FindItemByName(cart.Items, "Fish"));
            Console.WriteLine(cart.FindItemByName(cart.Items, "Rice"));


            /*Task 2*/
            Console.WriteLine("TASK 2");
            Console.WriteLine("ADD STUDENTS");
            Student student1 = new Student("Alex", "Belov", new int[] { 5, 7, 9, 10, 6 });
            Student student2 = new Student("Petras", "Petrauskas", new int[] { 9, 7, 9, 10, 9 });
            Student student3 = new Student("Jonas", "Jonaitis", new int[] { 5, 2, 9, 6, 1 });
            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);

            Console.WriteLine("ADD STUDENTS TO STUDENTLIST");
            StudentList studentList = new StudentList();
            studentList.AddStudent(student1);
            studentList.AddStudent(student2);
            studentList.AddStudent(student3);

            Console.WriteLine("FIND STUDENTS BY NAME AND SURNAME");
            Console.WriteLine(studentList.FindStudentByNameAndSurName("Alex", "Belov"));
            Console.WriteLine(studentList.FindStudentByNameAndSurName("Petras", "Petrauskas"));
            Console.WriteLine(studentList.FindStudentByNameAndSurName("Jonas", "Jonaitis"));

            Console.WriteLine("REMOVE STUDENTS BY NAME AND SURNAME");
            studentList.RemoveStudentByNameAndSurName("Alex", "Belov");

            foreach (Student student in studentList.Students)
            {
                if (student == null)
                {
                    break;
                }
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("AVERAGE GRADE OF ALL STUDENTS");
            Console.WriteLine(studentList.AverageGradeOfStudents());

        }
    }
}