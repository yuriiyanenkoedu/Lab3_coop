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

            public Student(string lineWithAllData)
            {
                string[] data = lineWithAllData.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                surName = data[0];
                firstName = data[1];
                patronymic = data[2];
                sex = char.Parse(data[3]);
                dateOfBirth = data[4];
                mathematicsMark = char.Parse(data[5]);
                physicsMark = char.Parse(data[6]);
                informaticsMark = char.Parse(data[7]);
                scholarship = int.Parse(data[8]);
            }
        }
        static Student[] ReadData(string fileName)
        {
            string[] fileData = File.ReadAllLines(fileName);
            Student[] resStud = new Student[fileData.Length];
            for (int i = 0; i < fileData.Length; i++)
            {
                resStud[i] = new Student(fileData[i]);
            }
            return resStud;
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
                            OutputStud(studs, StudWithAv(studs));
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
        static double Average(Student stud)
        {
            if (stud.physicsMark == '-')
                stud.physicsMark = '2';
            if (stud.mathematicsMark == '-')
                stud.mathematicsMark = '2';
            if (stud.informaticsMark == '-')
                stud.informaticsMark = '2';
            string s1 = stud.informaticsMark.ToString();
            string s2 = stud.mathematicsMark.ToString();
            string s3 = stud.physicsMark.ToString();
            double aver = double.Parse(s1) + double.Parse(s2) + double.Parse(s3);
            aver /= 3;
            return aver;
        }
        static int[] StudWithAv(Student[] stud)
        {
            int[] arr = new int[stud.Length];
            int count = 0;
            for (int i = 0; i < stud.Length; i++)
            {
                if (Average(stud[i]) > 4.5)
                {
                    arr[count] = i;
                    count++;
                }
            }
            Array.Resize(ref arr, count);
            return arr;
        }
        static void OutputStud(Student[] stud, int[] arr)
        {
            Console.WriteLine("Type of output");
            byte typeofuot = byte.Parse(Console.ReadLine());
            switch(typeofuot)
            {
                case 1:
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {   
                           Console.WriteLine("Student: {0} {1} {2}, average mark: {3}", stud[arr[i]].surName, stud[arr[i]].firstName, stud[arr[i]].patronymic, Math.Round(Average(stud[arr[i]]), 1));
                        }
                        break;
                    }
                case 2:
                    {
                        string text = "output.txt";
                        for (int i = 0; i < arr.Length; i++)
                        {
                            using (StreamWriter st = new StreamWriter(text, true))
                            {
                                st.WriteLine("Student: {0} {1} {2}, average mark: {3}", stud[arr[i]].surName, stud[arr[i]].firstName, stud[arr[i]].patronymic, Math.Round(Average(stud[arr[i]]), 1));
                            }
                        }
                        break;
                    }
            }
        }
        static double Step(Student[] stud)
        {
            int[] arr = new int[stud.Length];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (stud[arr[i]].scholarship > 0)
                {
                    count += stud[arr[i]].scholarship;
                }
            }
            int sbt = count * (2 / 10);
            int st = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (stud[arr[i]].scholarship < count - sbt)
                {
                    st = stud[arr[i]].scholarship;
                    Console.WriteLine(st);
                }
            }
            return st;
        }

        static void OutputSt(Student[] stud, int[] arr)
        {

            Console.WriteLine("Type of output");
            byte typeofuot = byte.Parse(Console.ReadLine());
            switch (typeofuot)
            {
                case 1:
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.WriteLine("Student: {0} {1} {2}, average mark: {3}", stud[arr[i]].surName, stud[arr[i]].firstName, stud[arr[i]].scholarship, Math.Round(Step(stud), 1));
                        }
                        break;
                    }
                case 2:
                    {
                        string text = "output.txt";
                        for (int i = 0; i < arr.Length; i++)
                        {
                            using (StreamWriter st = new StreamWriter(text, true))
                            {
                                st.WriteLine("Student: {0} {1} {2}, average mark: {3}", stud[arr[i]].surName, stud[arr[i]].firstName, stud[arr[i]].scholarship, Math.Round(Step(stud), 1));
                            }
                        }
                        break;
                    }
            }
        }
    }
}
