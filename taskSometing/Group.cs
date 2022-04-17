using System;
using System.Collections.Generic;
using System.Text;

namespace taskSometing
{
    class Group
    {
    
        public string Name { get; set; }
      
        public string No { get; set; }
        public string Category { get; set; }
        public bool IsOnline { get; set; }
    
        public int Limit { get; set; }

        public List<Student> Students { get; set; }


        public void AddStudent(Student obj)
        {
            if (Limit>Students.Count)
            {
                Students.Add(obj);
            }
            else
            {
                Console.WriteLine("Qrup  doludur");
            }
            
        }

        public Group(string no, string category, bool isOnline)
        {
            No = no;
            Category = category;
            IsOnline = isOnline;
            if (isOnline)
            {
                Limit = 15;
            }
            else
            {
                Limit = 10;
            }
            Students = new List<Student>();
        }

    }
}
