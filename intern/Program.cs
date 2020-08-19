using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using intern;

namespace sample1 { 
    class Program{
        private static List<intern.Members> list;
        public static List<intern.Members> readFile()
        {
            string reader = File.ReadAllText($"D:\\week 3\\c sharp intern\\see-sharp-intern\\intern\\intern\\members.json");
            var data = JsonConvert.DeserializeObject<List<intern.Members>>(reader);
            return data;
        }
        public static void ShowData(List<intern.Members> data)
        {
            foreach ( var i in data)
            {
                Console.WriteLine("=========");
                Console.WriteLine("MemberId:" + i.memberId);
                Console.WriteLine("FirstName:" + i.firstName);
                Console.WriteLine("LastName:" + i.lastName);
                Console.WriteLine("Gender:" + i.Gender);
                Console.WriteLine("Email" + i.Email);
                Console.WriteLine("=========");
            }
        }
        public static Members createMember()//nen dat ten hoa
        {
            Members m = new Members();
            Console.WriteLine("MemberId:");
            m.memberId = int.Parse(Console.ReadLine());
            Console.WriteLine("FirstName:");
            m.firstName = Console.ReadLine();
            Console.WriteLine("LastName:");
            m.lastName = Console.ReadLine();
            Console.WriteLine("Gender");
            m.Gender = Console.ReadLine();
            Console.WriteLine("Email");
            m.Email = Console.ReadLine();
            return m;
        }
        public static void editMember(List<intern.Members> data) //nen dat ten hoa
        {
            Console.WriteLine("Choose index to edit");
            int input = int.Parse(Console.ReadLine());
            for (var i = 0; i < data.Count; i++)
            {
                if (i == input)
                {
                    data[i] = new Members();
                    Console.WriteLine("MemberId:");
                    data[i].memberId = int.Parse(Console.ReadLine());
                    Console.WriteLine("FirstName:");
                    data[i].firstName = Console.ReadLine();
                    Console.WriteLine("LastName:");
                    data[i].lastName = Console.ReadLine();
                    Console.WriteLine("Gender");
                    data[i].Gender = Console.ReadLine();
                    Console.WriteLine("Email");
                    data[i].Email = Console.ReadLine();
                }
            }
            ShowData(data);
        }
        public static void delMem(List<intern.Members> data)
        {
            Console.WriteLine("Choose index to delete");
            int input = int.Parse(Console.ReadLine());
            data.RemoveAt(input);
            ShowData(data);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Option:");
            Console.WriteLine("1. Add members");
            Console.WriteLine("2. Edit members");
            Console.WriteLine("3. Delete members");
            Console.WriteLine("4. Show data");
            var a = int.Parse(Console.ReadLine());
            list = readFile();
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("Add members");
                        list.Add(createMember());
                        ShowData(list);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Edit members");
                        editMember(list);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Delete members");
                        delMem(list);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Show data");
                        ShowData(list);
                        break;
                    }
            }

        }
    }
}
