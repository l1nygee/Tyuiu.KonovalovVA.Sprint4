using Tyuiu.KonovalovVA.Sprint4.Task3.V5.Lib;
namespace Tyuiu.KonovalovVA.Sprint4.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] ar = {{ 3, 4, 8, 6, 3 },

                        { 9, 9, 3, 6, 9 },

                        { 5, 6, 7, 2, 3 },

                        { 3, 6, 2, 3, 8 },

                        { 5, 7, 2, 6, 4}};
            int wait = 25;
            int res = ds.Calculate(ar);
            Assert.AreEqual(wait, res);
        }
    }
}