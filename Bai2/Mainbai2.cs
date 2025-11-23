
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai2
{
    internal class Mainbai2
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            {
                students.Add(new Student("An Nguyen", 16, "S001"));
                students.Add(new Student("Anh Le", 17, "S002"));
                students.Add(new Student("Binh Tran", 14, "S003"));
                students.Add(new Student("Cuong Pham", 19, "S004"));
                students.Add(new Student("Duc Hoang", 15, "S005"));
            }
            ;
            
            

            while (true)
            {
                ShowMenu();
                Console.Write("Lua chon: ");
                string input = Console.ReadLine();
                int choice;
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Lua chon khong hop le!");
                    Pause();
                    Console.Clear();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        if (students.Count == 0)
                        {
                            Console.WriteLine("Danh sach rong.");
                        }
                        else
                        {
                            foreach (var stu in students)
                            {
                                stu.show();
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 2:
                        var filteredStudents = students.Where(s => s.Age >= 15 && s.Age <= 18);
                        if (!filteredStudents.Any())
                        {
                            Console.WriteLine("Khong co hoc sinh trong khoang tuoi 15-18.");
                        }
                        else
                        {
                            foreach (var stu in filteredStudents)
                            {
                                stu.show();
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 3:
                        var filteredByName = students.Where(s => !string.IsNullOrEmpty(s.Name) && s.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
                        if (!filteredByName.Any())
                        {
                            Console.WriteLine("Khong co hoc sinh co ten bat dau bang 'A'.");
                        }
                        else
                        {
                            foreach (var stu in filteredByName)
                            {
                                stu.show();
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 4:
                        if (students.Count == 0)
                        {
                            Console.WriteLine("Danh sach rong.");
                        }
                        else
                        {
                            int totalAge = students.Sum(s => s.Age);
                            Console.WriteLine("Tong tuoi cua tat ca hoc sinh: " + totalAge);
                        }
                        break;
                    case 5:
                        var sortedStudents = students.OrderBy(s => s.Age);
                        if (!sortedStudents.Any())
                        {
                            Console.WriteLine("Danh sach rong.");
                        }
                        else
                        {


                            foreach (var stu in sortedStudents)
                            {
                                stu.show();
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 6:
                        if (students.Count == 0)
                        {
                            Console.WriteLine("Danh sach rong.");
                        }
                        else
                        {
                            int maxAge = students.Max(s => s.Age);
                            var oldest = students.Where(s => s.Age == maxAge);
                            Console.WriteLine("Hoc sinh co tuoi lon nhat (" + maxAge + "):");
                            foreach (var stu in oldest)
                            {
                                stu.show();
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

                Pause();
                Console.Clear();
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("===MENU===");
            Console.WriteLine("1. In danh sach toan bo sinh vien");
            Console.WriteLine("2. Tim va in danh sach cac hoc sinh tu 15 den 18");
            Console.WriteLine("3. Tim va in ra hoc sinh co ten bat dau chu A");
            Console.WriteLine("4. Tinh Tong  tuoi cua tat ca hoc sinh trong danh sach");
            Console.WriteLine("5. Sap xep hoc sinh theo tuoi tang dan va in ra danh sach da sap xep");
            Console.WriteLine("6. Tim va in ra hoc sinh co tuoi lon nhat");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("=================");
        }


        private static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Nhan phim bat ky de tiep tuc...");
            Console.ReadKey(true);
        }
    }
}