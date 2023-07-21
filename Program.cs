using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyAssignment2
{
    public class Program
    {
        public List<string> listArray = new List<string>();
        static void Main(string[] args)
        {
            string item;string choice;
            LargeDataCollection obj = new LargeDataCollection();
            do
            {
                Console.WriteLine("Enter operations as follows \n1.Add\n2.Remove\n3.Acess Data");
                int opt =int.Parse(Console.ReadLine());
                switch(opt)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter item to be added");
                            item = Console.ReadLine();
                            obj.Add(item); break;
                        }
                    case 2: { Console.WriteLine("Enter name you want to remove");
                        item = Console.ReadLine();
                        obj.Remove(item); break;}
                    case 3:
                        {
                            Console.WriteLine("Enter index of item to access");
                            obj.AccessData(int.Parse(Console.ReadLine()));break;
                        }
                    default: { Console.WriteLine("Invalid Input");break; }
                }
                Console.WriteLine("Press y to continue");
                choice = Console.ReadLine().ToLower();

            }
            while(choice == "y");
            Console.WriteLine("All Data has been Disposed");
            obj.Dispose();
            Console.ReadKey();
        }
    }
}
