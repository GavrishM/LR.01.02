using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //Сделать метод ищущий кол-во товаров с ценой выше среднего.
    public class Analyzer
    {
        public double AVG(List<Sale> sales)
        {
            double result = 0;
            foreach (Sale sale in sales)
            {
                result += (sale.Price * sale.Quantity);
            }
            result /= sales.Count;
            return result;
        }
        public int MoreThenAVG(List<Sale> sales)
        {
            int result = 0;
            double avg = AVG(sales);
            foreach (Sale sale in sales)
            {
                if((sale.Price * sale.Quantity) > avg)
                { result++; }
            }
            return result;
        }
    }
}
