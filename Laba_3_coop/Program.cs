using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laba_3_coop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2, what variant are you want: 10, 12 or 17?\nTo exit enter '0'");
            int variant;
            do
            {
                variant = int.Parse(Console.ReadLine());
                switch (variant)
                {
                    case 10:
                        {
                            break;
                        }
                    case 12:
                        {
                            break;
                        }
                    case 17:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Choose variant please or enter 0 to exit");
                            break;
                        }
                }
            } while (variant != 0);
        }
    }
}
