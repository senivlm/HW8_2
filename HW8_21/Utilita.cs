using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace HW8_21
{

    class Utilita
    {
        private readonly string pathStorage1 = @"C:\\Users\\admin\\source\\repos\\HW8_21\\HW8_21\\Storage1.txt";
        private readonly string pathStorage2 = @"C:\\Users\\admin\\source\\repos\\HW8_21\\HW8_21\\Storage2.txt";
        private string[] reader1;
        private string[] reader2;
        private const string Message_File = "Check path Properly";
         Storage storage1;
         Storage storage2;
Треба поговорити про стиль
        public Utilita()
        {
            try
            {
                reader1 = File.ReadAllLines(pathStorage1);
                reader2 = File.ReadAllLines(pathStorage2);
            }
    Враховуйте, що Ви не відслідковуєте специфіку винятку
            catch (IOException)
            {
                Console.WriteLine("Message_File");
                Environment.Exit(1);
            }
            storage1 = Initilization(reader1);
            storage2 = Initilization(reader2);
        }

        public Utilita(string path, string path2)
        {
            try
            {
                reader1 = File.ReadAllLines(path);
                reader2 = File.ReadAllLines(path2);
            }
            catch (IOException)
            {
                Console.WriteLine("Message_File");
                Environment.Exit(1);
            }
            storage1 = Initilization(reader1);
            storage2 = Initilization(reader2);
        }

Не зрозумілий метод
        public Storage Initilization(string[] reader1)
        {
            string[] sub;
            Product[] product = new Product[reader1.Length];
            for (int i = 0; i < reader1.Length; i++)
            {
                sub = reader1[i].Split(' ');
                product[i] = new Product(sub[0], Convert.ToDouble(sub[1]));
            }
            return new Storage(product);
        }

Делегат краще було зробити поза класом
        public void allFunc(Program.More_or_Less del)
        {
            string result = null;
            string result1 = null;
            result = storage2.gotFirst(storage1);
            Console.WriteLine("Only in First");
            Console.WriteLine(result);
            Console.WriteLine("Evrything is diffrent");
            result1 = storage2.gotFirst(storage1);
            Console.WriteLine(result + result1);
            result = null;
            result1 = null;
            Console.WriteLine("Similar");
            result = storage1.HasTwo(storage2, del);
            Console.WriteLine(result);
        }


    }
}
