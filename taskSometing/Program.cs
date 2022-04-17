using System;
using System.Collections.Generic;

namespace taskSometing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool runProgram = true;
            List<Group> qruplar = new List<Group>();
             while (runProgram)
            {



                Logic(qruplar);


            }


            static void ShowMenu()
            {
                Console.WriteLine("----------");
                Console.WriteLine("1. Yeni qrup yarat ");
                Console.WriteLine("2. Qrupların siyahısını göstər ");
                Console.WriteLine("3. Qrup üzərində düzəliş etmək");
                Console.WriteLine("4. Qrupdakı telebelerin siyahısını göstər");
                Console.WriteLine("5. Bütün telebelerin siyahısını gostər");
                Console.WriteLine("6. Telebe yarat");
                Console.WriteLine("----------");
            }
            static void Option1(List<Group> qruplar)
            {
                Console.WriteLine("qrup yaradilir ...");
                Console.WriteLine("qrup adi daxil edin ");
                
                string no = Console.ReadLine();
                bool check  = isQrupExsist(qruplar, no);
                if (check)
                {
                    Console.WriteLine("bu adda qrup var menyuya qayidirsiz");
                    return;
                }
                Console.WriteLine("qrup categoriyasi daxil edin ");
                string category = Console.ReadLine();
                Console.WriteLine("qrup online olub olmamasini  daxil edin (true/false) ");
                string boolcheck = Console.ReadLine().ToLower();
                string limit = isTrueFalse(boolcheck);
                if (limit=="bad")
                {
                    Console.WriteLine("yanlis deyer menyuya qayidirsiz");
                    return;
                }
                bool isOnline = bool.Parse(limit);
                
                var temp = new Group(no,category,isOnline);


                qruplar.Add(temp);

            }
            static void Option2(List<Group> qruplar)
            {
                Console.WriteLine("butun qruplar ... ");
                foreach (var item in qruplar)
                {
                    Console.WriteLine($"qrup nomesi : {item.No} ,qrup kateqoryasi : {item.Category} ,qrup limiti : {item.Limit} ,qrup online : {item.IsOnline}");
                }


            }
            static void Option3(List<Group> qruplar)
            {

                Console.WriteLine("qrup uzerinde deyisiklik qrupun adini daxil edin ... ");
                Console.WriteLine("adi deyisecek olan qrupun  adini daxil edin ");

                string no = Console.ReadLine();
                bool check = isQrupExsist(qruplar, no);
                if (!check)
                {
                    Console.WriteLine("bu adda qrup yoxdur menyuya qayidirsiz");
                    return;
                }
               
                Console.WriteLine("Yeni qrup adini daxil edin ");

                string new_no = Console.ReadLine();
                if (isQrupExsist(qruplar, new_no))
                {
                    Console.WriteLine("bu ad hemde  basqa qrupda var yanlis deyer menyuya qayidirsiz");
                    return;
                }
                foreach (var qrup in qruplar)
                {
                    if (qrup.No==no)
                    {
                        qrup.No = new_no;
                    }
                }

            }
            static void Option4(List<Group> qruplar)
            {
                bool check = true;
                Console.WriteLine("qrupun adini daxil edin");
                string qrup_name = Console.ReadLine();

                foreach (var qrup in qruplar)
                {
                    if (qrup_name==qrup.No)
                    {
                        check = false;
                        Console.WriteLine("+++++");
                        Console.WriteLine($"{qrup_name} qrupunun telebeleri ... ");
                        
                        foreach (var item in qrup.Students)
                        {
                            item.ShowInfo();
                        }
                        break;
                    }
                }
                if (check)
                {
                    Console.WriteLine("bu ad da qrup yoxdur , meynuya qayidirsiz ");
                }
               
              
            }
            static void Option5(List<Group> qruplar)
            {
                foreach (var item in qruplar)
                {
                    foreach (var stu in item.Students)
                    {
                        stu.ShowInfo();
                    }
                }
            }
            static void Option6(List<Group> qruplar)
            {

                Console.WriteLine("telebe yaradilir ...");
                Console.WriteLine("hansi qrupa elave olunsun");
                string qrup_name = Console.ReadLine();
                
                bool checkQrup = isQrupExsist(qruplar, qrup_name); ;
              
                if (!checkQrup)
                {
                    Console.WriteLine("bu ad da qrup yoxdur menyuya qayidirsiz");
                    return;
                }
                Console.WriteLine(" adi daxil edin ");
                string fullname = Console.ReadLine();

                Console.WriteLine("Telebenin zemanetli olub olmamasini  daxil edin (true/false) ");
                string zemanet = Console.ReadLine().ToLower();

                if (isTrueFalse(zemanet)=="bad")
                {
                    Console.WriteLine("yanlis deyer menyuya qayidirsiz");
                    return;
                }

                var stu = new Student(fullname, qrup_name,bool.Parse(zemanet));
                foreach (var qrup in qruplar)
                {
                    if (qrup.No==qrup_name)
                    {
                        
                        qrup.AddStudent(stu);
                        break;
                    }
                  
                }

                
            }



            static bool isQrupExsist(List<Group> qruplar,string qrup_name)
            {
                bool checkQrup = false;
                foreach (var qrup in qruplar)
                {
                   

                        if (qrup.No == qrup_name)
                        {
                            checkQrup = true;
                        }

                    
                }
                if (checkQrup)
                {
                   
                    return true;
                }
                else
                {
                    return false;
                }
            }
           
            static string isTrueFalse(string answer)
            {

                if (answer=="true"||answer=="false")
                {
                    return answer;
                }
                else
                {
                    return "bad";
                }
            }
            static void Logic(List<Group> qruplar)
            {
                ShowMenu();
                string key = Console.ReadLine();
                if (key=="1")
                {
                    Option1(qruplar);
                }
                else if (key=="2")
                {
                    Option2(qruplar);
                }
                else if (key == "3")
                {
                    Option3(qruplar);
                }
                else if (key == "4")
                {
                    Option4(qruplar);
                }
                else if (key == "5")
                {
                    Option5(qruplar);
                }
                else if (key == "6")
                {
                    Option6(qruplar);
                }
                else
                {
                    Console.WriteLine("yanlis deyer daxil edildi 1,2 .. 6 ya qeder bir eded secin ");
                }
            }

        }
    }
}
