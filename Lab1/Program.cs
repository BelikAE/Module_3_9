using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codOper = 0;
            int x = 0;
            int y = 0;
            Console.WriteLine("Вас привествует калькулятор!");
            try
            {
                Console.WriteLine("Введите целое число X.");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целое число Y.");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:" +
                    "\n   1 - сложение" +
                    "\n   2 - вычитание" +
                    "\n   3 - произведение" +
                    "\n   4 - частное");
                codOper = Convert.ToInt32(Console.ReadLine());
                switch (codOper)
                {
                    case 1:
                        {
                            Console.WriteLine($"Ваш выбор: {x + y}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Ваш выбор: {x - y}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Ваш выбор: {x * y}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Ваш выбор: {x / y}");
                            break;
                        }
                    default: 
                        {
                            Console.WriteLine("Нет операции с указанным номером");
                            break;
                        }
                }
            }
            catch (DivideByZeroException ex) when (y == 0 || codOper == 4) 
            {

                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
