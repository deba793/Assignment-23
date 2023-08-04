using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    internal class LoginOpearation
    {
        static List<Logging> list = new List<Logging>()
        {
            new Logging {ID = 2567455,Password = "b1434"},
            new Logging {ID = 2567456,Password = "b15635"},
            new Logging {ID = 2567457,Password = "b123896"},
            new Logging {ID = 2567458,Password = "b124537"},
            new Logging {ID = 2567459,Password = "b127838"},
        };
        public static void login()
        {
            Logging loginDetails = new Logging();
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            Logging l = list.SingleOrDefault(e => e.ID == id && e.Password == password);
            if (l != null)
            {
                Console.WriteLine("Login Successfull!!");
            }
            else
            {
                Console.WriteLine("Invalid Details!!");
            }

        }
    }
}
