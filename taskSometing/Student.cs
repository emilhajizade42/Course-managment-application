using System;
using System.Collections.Generic;
using System.Text;

namespace taskSometing
{
    class Student
    {
        public string Fullname { get; set; }
        public string Group_No { get; set; }
        public bool Zemanet { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"FULLNAME : {Fullname}|| GROUP  :  {Group_No} || ZEMANET : {Zemanet} ");
        }
        public Student(string fullname,string group_No, bool zemanet)
        {
            Fullname = fullname;
            Group_No = group_No;
            Zemanet = zemanet;
        }
    }
}
