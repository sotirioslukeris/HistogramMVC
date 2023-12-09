using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Histogram.Views
{
    internal class Display
    {
        public double[] Numbers { get; set; }

        public int NumbersCount { get; set; }

        public double CalculatePercentage { get; set; }

        public double P1 { get; set; }
        public double P2 { get; set; }

        public double P3 { get; set; }
        public double P4 { get; set; }
        public double P5 { get; set; }

        public Display()
        {
            Numbers = new double[NumbersCount];
            NumbersCount = 0;
            CalculatePercentage = 0;
            P1 = 0;
            P2 = 0;
            P3 = 0;
            P4 = 0;
            P5 = 0;
            GetValues();
        }
        public void GetValues()
        {
            Console.WriteLine("Insert count of numbers:");
            NumbersCount = int.Parse(Console.ReadLine());
            Numbers = new double [NumbersCount];

            for (int i = 0; i < NumbersCount; i++)
            {
                Numbers[i] = double.Parse(Console.ReadLine());
            }
        }

        public void ShowHistogram()
        {
            Console.WriteLine("{0:P}", P1);
            Console.WriteLine("{0:P}", P2);
            Console.WriteLine("{0:P}", P3);
            Console.WriteLine("{0:P}", P4);
            Console.WriteLine("{0:P}", P5);
        }


    }
}
