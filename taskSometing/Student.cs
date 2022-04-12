using System;
using System.Collections.Generic;
using System.Text;

namespace taskSometing
{
    class Student
    {
        public string Fullname { get; set; }
        public string Group_No { get; set; }
        public bool zemanet { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"ad : {Fullname},grup :  {Group_No} ,zament : {zemanet} ");
        }
        public Student(string fullname)
        {
            Fullname = fullname;
            
        }
    }
}
