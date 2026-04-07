using ClassLibrary;
using static ClassLibrary.Importer;

namespace TestProject
{
    [TestClass]
    public sealed class ImporterTest
    {
        [TestMethod]
        public void ImportTest()
        {
            string path;
            List<Sale> sales = new List<Sale>();
            Importer imp = new Importer();
            path = "../../../../Texts/t.txt";
            sales = imp.Import(path);
            List<Sale> expected = new List<Sale>();
            expected.Add(new Sale("t", 1, 1));
            expected.Add(new Sale("p", 2, 2));
            expected.Add(new Sale("y", 3, 3));
            expected.Add(new Sale("i", 4, 4));
            Assert.AreEqual(expected.Count, sales.Count);
            for (int i = 0; i < sales.Count; i++)
            {
                //Assert.AreEqual(expected[i], sales[i]);
                Assert.AreEqual(expected[i].Name, sales[i].Name);
                Assert.AreEqual(expected[i].Price, sales[i].Price);
                Assert.AreEqual(expected[i].Quantity, sales[i].Quantity);
            }

        }
    }
}
