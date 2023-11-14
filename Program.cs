using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_nizovi_zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] brdiv1 = new int[n];
            int[] brndiv2 = new int[n];
            int temporary = 0;
            Console.WriteLine("Unesite najviše 10 parnih i 10 neparnih brojeva.");
            int i = 0, divTwo = 0, notDivTwo = 0;

            while ((temporary != 0 || divTwo < 10 || notDivTwo < 10) && i < 20)
            {
            start: try
                {
                    Console.Write((i + 1) + ". ");
                    temporary = Convert.ToInt32(Console.ReadLine());
                    if (temporary % 2 == 0)
                    {
                        brdiv1[divTwo] = temporary;
                        i++;
                        divTwo++;
                    }
                    if (temporary % 2 == 1)
                    {
                        brndiv2[notDivTwo] = temporary;
                        i++;
                        notDivTwo++;
                    }
                    if (temporary == 0)
                    {
                        goto end;
                    }
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("Unesite drugi broj"); ;
                    goto start;
                }
                catch (System.IndexOutOfRangeException e)
                {
                    goto end;
                }
            }
        end: Console.Write("Paran broj: ");
            foreach (int number in brdiv1)
            {
                Console.Write(number + ", ");
            }
            Console.Write("Neparani brojevi: ");
            foreach (int number in brndiv2)
            {
                Console.Write(number + ", ");
            }
            Console.ReadKey();
        }
    }
}