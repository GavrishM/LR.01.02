using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    public class Importer
    {
        public List<Sale> Import(string path)
        {
            List<Sale> sales = new List<Sale>();
            StreamReader reader = new StreamReader(path);
            string line;
            string[] parts;
            while ((line = reader.ReadLine()) != null)
            {
                parts = line.Split(';');

                if (parts.Length == 3)
                {
                    sales.Add(new Sale
                    {
                        Name = parts[0],
                        Price = Convert.ToInt32(parts[1]),
                        Quantity = Convert.ToInt32(parts[2])
                    });
                }
            }
            return sales;
        }
    }
}
