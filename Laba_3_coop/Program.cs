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
        struct Student
        {
            public string surName;
            public string firstName;
            public string patronymic;
            public char sex;
            public string dateOfBirth;
            public char mathematicsMark;
            public char physicsMark;
            public char informaticsMark;
            public int scholarship;

            public Student(string[] lineWithAllData)
            {
                
                surName = lineWithAllData[0];
                firstName = lineWithAllData[1];
                patronymic = lineWithAllData[2];
                sex = char.Parse(lineWithAllData[3]);
                dateOfBirth = lineWithAllData[4];
                mathematicsMark = char.Parse(lineWithAllData[5]);
                physicsMark = char.Parse(lineWithAllData[6]);
                informaticsMark = char.Parse(lineWithAllData[7]);
                scholarship = int.Parse(lineWithAllData[8]);
                // TODO   you SHOULD IMPLEMENT constructor with exactly this signature
                // lineWithAllData is string contating all data about one student, as described in statement
            }
        }
        static Student[] ReadData(string fileName)
        {
            // TODO   implement this method.
            // It should read the file whose fileName has been passed and fill 
        }

        static void runMenu(Student[] studs)
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

        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");
            runMenu(studs);
        }
    }
}
