using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Classes
{
    public class Student
    {
        public int SoonerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOnProbation { get; set; }
        public double GPA { get; set; }

        private double BursarBalance;

        //public List<string> Majors { get; set; }

        //public UniversityCourse Course { get; set; }

        /// <summary>
        /// Default/Empty Constructor
        /// </summary>
        public Student()
        {
            SoonerID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 0;
            //Majors = new List<string>();
            //Course = new UniversityCourse();
        }

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="BursarBalance"></param>
        public Student(int id, string fName, string lName, double BursarBalance)
        {
            SoonerID = id;
            FirstName = fName;
            LastName = lName;
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;
        }

        public void MakePayment(double amount)
        {

            if (amount < 0)
            {
                Console.WriteLine("Invalid");
                //throw new Exception("Amount must be greater than 0");
            }
            //Assumed x for y
            BursarBalance -= amount;
            //BursarBalance = BursarBalance - amount;
        }

        
        public double CheckBalance()
        {
            return BursarBalance;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName} ({SoonerID.ToString("N0")})";
        }

    }

    //public class UniversityCourse
    //{
    //}
}
