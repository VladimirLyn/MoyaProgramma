﻿using System;
using System.IO;
namespace MoyaProgramma
{
    class Program
    {
       
        public class man
        {
            public string FirstName;
            public string LastName;
            public string Patronymic;
            public string Sage;
            public int Iage;
            public string sID;
            public long iID;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вы записывали данные ранее y/n ");

            string HowGoing = Console.ReadLine();

            if (HowGoing == "y")
            {
                StreamReader sr = new StreamReader(@"c:\CSharp Output\MyFile.txt");

                string line = sr.ReadLine();

                Console.WriteLine(line);

                Console.ReadLine();

            }
            if (HowGoing == "n")
            {
                man MyMan = new man();

                Console.WriteLine("Введите свою фамилию");

                MyMan.LastName = Console.ReadLine();

                Console.WriteLine("Введите своё имя");

                MyMan.FirstName = Console.ReadLine();

                Console.WriteLine("Введите своё отчество");

                MyMan.Patronymic = Console.ReadLine();

                Console.WriteLine("Введите свой возраст");

                string Sage = MyMan.Sage = Console.ReadLine();

                MyMan.Iage = int.Parse(Sage);

                if (MyMan.Iage <= 0) Console.WriteLine("Ты тип ещё даже не родилась?");

                else if (MyMan.Iage >= 18 && MyMan.Iage < 35) Console.WriteLine("В самый раз");

                else if (MyMan.Iage <= 18) Console.WriteLine("18 ещё нет, а это проблема");

                else if (MyMan.Iage >= 35 && MyMan.Iage < 50) Console.WriteLine("Немного в возрасте");

                else if (MyMan.Iage >= 50 && MyMan.Iage < 70) Console.WriteLine("Уже в почтительном возрасте");

                else if (MyMan.Iage >= 70 && MyMan.Iage < 150) Console.WriteLine("Уже на пенсии");

                else if (MyMan.Iage >= 150) Console.WriteLine("Полтора века прожил, не верю я в это");

                Console.WriteLine("Введите ваш ID");

                string sID = MyMan.sID = Console.ReadLine();

                MyMan.iID = int.Parse(sID);

                FileInfo fileInfo = new FileInfo(@"c:\CSharp Output\MyFile.txt");

                StreamWriter sw = fileInfo.CreateText();

                sw.WriteLine(MyMan.LastName + " " + MyMan.FirstName + " " + MyMan.Patronymic + " " + MyMan.Iage + " " + MyMan.sID);

                sw.Close();

                Console.WriteLine(MyMan.LastName + " " + MyMan.FirstName + " " + MyMan.Patronymic + " " + MyMan.Iage + " " + MyMan.sID);

                Console.ReadLine();
                
                if(HowGoing!="y" && HowGoing!= "n")
                {
                    Console.WriteLine("не правильная запись, ошибка");
                    Console.ReadLine();
                }
              
            }
        }
    }
}
