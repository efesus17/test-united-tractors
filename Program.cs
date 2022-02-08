using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan Loker yang dicari: ");
            int x = Convert.ToInt32(Console.ReadLine());
            cariLoker(x);
            Console.ReadLine();
        }
        static void cariLoker(int x)
        {
            bool flag = false;
            while (flag)
            {
                
                int lantai = 1;
                bool nine_loker = true;
                bool three_loker = false;
                bool seven_loker = false;
                bool two_loker = false;

                int[] num = { };

                if (flag)
                {
                    for (int i = 1; i < x; i++)
                    {
                        if (x == i)
                        {
                            Console.WriteLine("Loker Berada Di lantai" + x);
                        }
                        else if (nine_loker == false && num.Length == 9)
                        {
                            lantai += 1;
                            nine_loker = false;
                            three_loker = true;
                        }
                        else if (three_loker == false && num.Length == 9)
                        {
                            lantai += 1;
                            three_loker = false;
                            seven_loker = true;
                        }
                        else if (seven_loker == false && num.Length == 9)
                        {
                            lantai += 1;
                            seven_loker = false;
                            two_loker = true;
                        }
                        else if (two_loker == false && num.Length == 9)
                        {
                            lantai += 1;
                            three_loker = false;
                            nine_loker = true;
                        }

                        Console.WriteLine("loker tidak ditemukan");
                        }
                    }   
                    else
                    {
                    Console.WriteLine("Masukan angka ");
                    }
                }

            }
        }
    }

