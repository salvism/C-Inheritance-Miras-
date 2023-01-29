using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string countStr;
            int count = 0;
            do
            {
                Console.Write("Count of students: ");
                countStr = Console.ReadLine();
                if (!CheckCount(countStr))
                    Console.WriteLine("Please enter a valid number!");
               
            } while (!CheckCount(countStr));

            count = Convert.ToInt32(countStr);
            Student[] students = new Student[count];


            for (int i = 0; i < students.Length; i++)
            {
                string fullName;
                bool checkFullName = false;
                do
                {
                    Console.Write("Fullname: ");
                    fullName = Console.ReadLine();
                    checkFullName = CheckFullName(fullName);
                    if (checkFullName == false)
                        Console.WriteLine("Try Again\n");

                } while (checkFullName == false);

                string groupNo;
                bool checkGroupNo = false;
                do
                {
                    Console.Write("GroupNo: ");
                    groupNo = Console.ReadLine();
                    checkGroupNo = CheckGroupNo(groupNo);
                    if (checkGroupNo == false)
                        Console.WriteLine("Try Again\n");

                } while (checkGroupNo == false);

                Student student = new Student
                {
                    FullName = fullName,
                    GroupNo = groupNo
                };

                students[i] = student;
            }

            string operation;
            do
            {
                Console.WriteLine("\n1. See all students");
                Console.WriteLine("2. Search by students");
                Console.WriteLine("3. Add a student");
                Console.WriteLine("0. Exit menu\n");

                Console.Write("Choose an operation: ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "1":
                        foreach (var item in students)
                        {
                            Console.WriteLine($"FullName: {item.FullName} , GroupNo: {item.GroupNo}");
                        }
                        operation = "-1";
                        break;
                    case "2":
                        Console.Write("Enter FullName or GroupNo:");
                        string wantedValue = Console.ReadLine();

                        foreach (var item in students)
                        {
                            if (item.FullName.Contains(wantedValue) || item.GroupNo.Contains(wantedValue))
                            {
                                Console.WriteLine($"FullName: {item.FullName} , GroupNo: {item.GroupNo}");
                            }
                        }
                        operation = "-1";
                        break;
                    case "3":

                        AddStudent(students, count);

                        operation = "-1";
                        break;
                    case "0":
                        Console.WriteLine("Goodbye");
                        operation = "0";
                        break;
                    default:
                        Console.WriteLine("Wrong operation");
                        operation = "-1";
                        break;
                }
            } while (operation == "-1");

            #region bike
            //Console.Write("Count of bikes: ");
            //string countStr = Console.ReadLine();
            //int count = Convert.ToInt32(countStr);

            //Bicycle[] bicycles = new Bicycle[count];

            //for (int i = 0; i < bicycles.Length; i++)
            //{
            //    string brand;
            //    do
            //    {
            //        Console.Write("Brand: ");
            //        brand = Console.ReadLine();
            //    } while (string.IsNullOrWhiteSpace(brand));

            //    string model;
            //    do
            //    {
            //        Console.Write("Model: ");
            //        model = Console.ReadLine();
            //    } while (string.IsNullOrWhiteSpace(model));

            //    Bicycle bike = new Bicycle
            //    {
            //        Brand = brand,
            //        Model = model
            //    };

            //    bicycles[i] = bike;
            //}

            //Console.WriteLine("1. See all bikes");
            //Console.WriteLine("2. Search bikes by model name");

            //Console.WriteLine("Select an operation:");
            //string opr = Console.ReadLine();

            //if (opr == "1")
            //{
            //    foreach (var item in bicycles)
            //    {
            //        Console.WriteLine($"Brand: {item.Brand} , Model: {item.Model} , Mileage: {item.Mileage}");
            //    }
            //}
            //else if (opr == "2")
            //{
            //    Console.Write("Enter Model: ");
            //    string wantedModel = Console.ReadLine();

            //    foreach (var item in bicycles)
            //    {
            //        if (item.Model.Contains(wantedModel))
            //        {
            //            Console.WriteLine($"Brand: {item.Brand} , Model: {item.Model} , Mileage: {item.Mileage}");
            //        }
            //    }
            //}
            #endregion

            #region product

            //Product product1 = new Product("Product 1", 444);
            //Phone phone1 = new Phone("Samsung Galaxy Note9", 2000)
            //{
            //    Camera = 12
            //};

            //Phone[] phones = new Phone[2];



            //for (int i = 0; i < phones.Length; i++)
            //{
            //    Console.Write("Phone Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Price: ");
            //    string priceStr = Console.ReadLine();
            //    double price = Convert.ToDouble(priceStr);

            //    Console.Write("Camera: ");
            //    string cameraStr = Console.ReadLine();
            //    int camera = Convert.ToInt32(cameraStr);

            //    Phone phone = new Phone(name, price)
            //    {
            //        Camera= camera
            //    };

            //    phones[i] = phone;
            //}

            //string option;
            //do
            //{
            //    Console.WriteLine("1. Telefonlara bax");
            //    Console.WriteLine("2. Adina gore axtaris et");
            //    Console.WriteLine("3. Telefon elave et");
            //    Console.WriteLine("0. Cix");

            //    option = Console.ReadLine();

            //    switch (option)
            //    {
            //        case "1":
            //            Console.WriteLine("Butun telefonlar");
            //            foreach (var item in phones)
            //            {
            //                Console.WriteLine($"Name: {item.Name} | Price: {item.Price} | Camera: {item.Camera}");
            //            }
            //            break;
            //        case "2":
            //            Console.WriteLine("Telefonlar icerisinde axtaris et");
            //            string wantedPhone = Console.ReadLine();
            //            foreach (var item in phones)
            //            {
            //                if (item.Name.Contains(wantedPhone))
            //                {
            //                    Console.WriteLine($"Name: {item.Name} | Price: {item.Price} | Camera: {item.Camera}");
            //                }
            //            }
            //            break;
            //        case "3":
            //            Console.WriteLine("Yeni telefon yaratmaq");
            //            AddPhone(phones);

            //            break;
            //        case "0":
            //            option = "-1";
            //            Console.WriteLine("Eminsinizmi? y/n");
            //            if (Console.ReadLine() == "y")
            //            {
            //                option = "0";
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Yanlis secim etdiniz, yeniden secin!");
            //            break;
            //    }
            //} while (option != "0");

            #endregion

        }
        static bool CheckCount(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                    return false;
            }
            return true;
        }
        static bool IsDigit(string str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                    return false;
            }
            return true;
        }
        static bool CheckGroupNo(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[0]) && str.Length == 4)
                {
                    for (int j = 1; j < str.Length; j++)
                    {
                        if (IsDigit(str))
                            return true;
                    }
                }
            }
            return false;
        }
        static bool CheckFullName(string str)
        {
            if (!char.IsUpper((char)str[0]))
                return false;
            else
            {
                for (int i = 1; i < str.Length; i++)
                {
                    if (!char.IsLetter(str[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static Student[] AddStudent(Student[] arr, int size)
        {
            Student[] newArr = new Student[size];

            string fullName;
            bool checkFullName = false;
            do
            {
                Console.Write("Fullname: ");
                fullName = Console.ReadLine();
                checkFullName = CheckFullName(fullName);
                if (checkFullName == false)
                    Console.WriteLine("Try Again\n");

            } while (checkFullName == false);

            string groupNo;
            bool checkGroupNo = false;
            do
            {
                Console.Write("GroupNo: ");
                groupNo = Console.ReadLine();
                checkGroupNo = CheckGroupNo(groupNo);
                if (checkGroupNo == false)
                    Console.WriteLine("Try Again\n");

            } while (checkGroupNo == false);

            Student student = new Student
            {
                FullName = fullName,
                GroupNo = groupNo
            };

            for (int i = 0; i < size; i++)
            {
                Array.Resize(ref newArr, size + 1);
                newArr[size - 1] = arr[i];
            }

            return newArr;
        }
        static Phone[] AddPhone(Phone[] arr)
        {
            Phone[] newArr = new Phone[2];

            Console.Write("Phone Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            string priceStr = Console.ReadLine();
            double price = Convert.ToDouble(priceStr);

            Console.Write("Camera: ");
            string cameraStr = Console.ReadLine();
            int camera = Convert.ToInt32(cameraStr);

            Phone phone = new Phone(name, price)
            {
                Camera = camera
            };

            for (int i = 0; i < 2; i++)
            {
                Array.Resize(ref newArr, 3);
                newArr[2] = arr[i];
            }

            return newArr;
        }
    }
}
