using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StudentApp.Model
{
    internal class Student
    {
        private int rollno;
        private string name;
        private double cgpa;

        public int RollNo
        {
            get { return rollno; }
            set
            {
                if (ValidateRollNo(value))
                { 
                    rollno = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = ValidateName(value);
            }
        }

        public double CGPA
        {
            get { return cgpa; }
            set
            {
                if (ValidateCgpa(value))
                {
                    cgpa = value;
                }
            }
        }


        public bool ValidateRollNo(int value)
        {
            if (value > 0)
                return true;
            else
                Console.WriteLine("Roll number must be a positive value.");
            return false;
        }

        public string ValidateName(string value)
        {
            if (value.Length >= 5)
                return value;
            return "";

        }
        public bool ValidateCgpa(double value)
        {
            if (value >= 1 && value <= 10)
                return true;
            else
                Console.WriteLine(" CGPA must be in the range 1 to 10.");
            return false;

        }




        public double CalculatePercentage()
        {
            double conversionFactor = 9.5;
            double conversionOffset = 0;

            double percentage = cgpa * conversionFactor + conversionOffset;

            return percentage; 
        }
    }
}