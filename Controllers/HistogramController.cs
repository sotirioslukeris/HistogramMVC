using MVC_Histogram.Model;
using MVC_Histogram.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Histogram.Controllers
{
    internal class HistogramController
    {
        private Histogram histogram;
        private Display display;

        public HistogramController()
        {
            display = new Display();
            histogram = new Histogram(display.NumbersCount,display.Numbers );
            display.CalculatePercentage = histogram.CalculatePercentage();
            display.P1 = histogram.P1();

            display.P2 = histogram.P2();

            display.P3 = histogram.P3();

            display.P4 = histogram.P4();

            display.P5 = histogram.P5();

            Console.WriteLine();

            display.ShowHistogram();
        }
    }
}
