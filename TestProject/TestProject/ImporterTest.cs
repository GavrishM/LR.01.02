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
            path = "../../Texts/t.txt";
            sales = imp.Import(path);
            List<Sale> expected = new List<Sale>();
            CollectionAssert.AreEqual(expected, sales);
            
        }
    }
}
