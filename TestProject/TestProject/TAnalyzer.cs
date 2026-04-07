using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class TAnalyzer
    {
        [TestMethod]
        public void TAVG()
        {
            List<Sale> sales = new List<Sale>();
            Analyzer an = new Analyzer();
            sales.Add(new Sale("t", 1, 1));
            sales.Add(new Sale("p", 2, 2));
            sales.Add(new Sale("y", 3, 3));
            sales.Add(new Sale("i", 4, 4));

            double expected = 7.5;
            double actual = an.AVG(sales);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TMoreThenAVG()
        {
            List<Sale> sales = new List<Sale>();
            Analyzer an = new Analyzer();
            sales.Add(new Sale("t", 1, 1));
            sales.Add(new Sale("p", 2, 2));
            sales.Add(new Sale("y", 3, 3));
            sales.Add(new Sale("i", 4, 4));

            int expected = 0;
            double avg = an.AVG(sales);
            foreach (Sale sale in sales)
            {
                if ((sale.Price * sale.Quantity) > avg)
                { expected++; }
            }
            int actual = an.MoreThenAVG(sales);

            Assert.AreEqual(expected, actual);
        }
    }
}
