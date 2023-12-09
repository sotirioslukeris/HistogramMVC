using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Histogram.Controllers;
namespace MVC_Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HistogramController his = new HistogramController();

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
                
            
            
        }
    }
}
