using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Histogram.Model
{
    internal class Histogram
    {
        private int numbersCount;
        private double[] numbers;



        public Histogram(int numbersCount, double[] numbers)
        {
            this.NumbersCount = numbersCount;
            this.Numbers = numbers;
        }

        public Histogram() : this(0, null) { }

        public double[] Numbers
        {
            get { return numbers; }
            set
            {
                for (int i = 0; i < numbersCount; i++)
                {
                    if (value[i] > 1000 || value[i] < 1)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    numbers = value;
                }
            }



        }

        public int NumbersCount
        {
            get { return numbersCount; }
            set
            {
                if (value > 1000 || value < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                numbersCount = value;
            }
        }

        public double CalculatePercentage()
        {
            return NumbersCount * 100;
        }

        public double P1()
        {
            int p1NumsCount = 0;
            double p1Percentage = 0;
            for (int i = 0; i < NumbersCount; i++)
            {
                if (Numbers[i] < 200)
                {
                    p1NumsCount++;
                    
                }
            }

            p1Percentage = p1NumsCount / CalculatePercentage();

            return p1Percentage*100;
        }

        public double P2()
        {
            int p2NumsCount = 0;
            double p2Percentage = 0;
            for (int i = 0; i < NumbersCount; i++)
            {
                if (Numbers[i] >= 200 && Numbers[i] <= 399)
                {
                    p2NumsCount++;

                }

            }

            p2Percentage = p2NumsCount / CalculatePercentage();

            return p2Percentage*100;
        }


        public double P3()
        {
            int p3NumsCount = 0;
            double p3Percentage = 0;
            for (int i = 0; i < NumbersCount; i++)
            {
                if (Numbers[i] >= 400 && Numbers[i] <= 599)
                {
                    p3NumsCount++;

                }

            }

            p3Percentage = p3NumsCount / CalculatePercentage();

            return p3Percentage* 100;

        }

        public double P4()
        {
            int p4NumsCount = 0;
            double p4Percentage = 0;
            for (int i = 0; i < NumbersCount; i++)
            {
                if (Numbers[i] >= 600 && Numbers[i] <= 799)
                {
                    p4NumsCount++;

                }

            }

            p4Percentage = p4NumsCount / CalculatePercentage();

            return p4Percentage * 100;

        }

        public double P5()
        {
            int p5NumsCount = 0;
            double p5Percentage = 0;
            for (int i = 0; i < NumbersCount; i++)
            {
                if (Numbers[i] >= 800)
                {
                    p5NumsCount++;

                }

            }

            p5Percentage = p5NumsCount / CalculatePercentage();

            return p5Percentage * 100;
        }



    }
}
