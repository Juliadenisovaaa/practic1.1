using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przt1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //входные данные
            double massS1 = 4; //масса первого раствора
            double massS2 = 6; //масса второго раствора
            double concentratS1 = 10; //концентрация соли в первом расстворе
            double concentratS2 = 15; //концентрация соли во втором расстворе

            // Расчет массы соли в каждом растворе
            double massOfSalt1 = massS1 * concentratS1 / 100;
            double massOfSalt2 = massS2 * concentratS2 / 100;

            // Расчет общей массы и общей массы соли

            double totalMass = massS1 + massS2;
            double totalSalt = massOfSalt1 + massOfSalt2;

            // Расчет концентрации соли в новой смеси
            double totalConcentrat = totalSalt / totalMass * 100;

            // Вывод результата
            Console.WriteLine("Концентрация соли в новой смеси: " + totalConcentrat + "%");

        }
    }
}
