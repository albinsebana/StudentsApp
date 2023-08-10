using StudentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class StudentApp
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
 
            Console.Write("Enter Roll NUmber: ");
            student1.RollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            student1.Name = Console.ReadLine();

            Console.Write("Enter Student CGPA: ");
            student1.CGPA = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Student 1: RollNo = {0}, Name = {1}, CGPA = {2}", student1.RollNo, student1.Name, student1.CGPA);

            Console.WriteLine("Student 1 Percentage: {0}%", student1.CalculatePercentage());

            // This will print an error message.
            //Student student2 = new Student();
            //student2.RollNo = -133; 
            //student2.Name = "Alb";
            //student2.CGPA = 7.6;     // This will print an error message.
            //Console.WriteLine("Student 2: RollNo = {0}, Name = {1}, CGPA = {2}", student2.RollNo, student2.Name, student2.CGPA);
            //Console.WriteLine("Student 2 Percentage: {0}%", student2.CalculatePercentage());
        }
    }
}
