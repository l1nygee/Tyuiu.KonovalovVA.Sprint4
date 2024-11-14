using Tyuiu.KonovalovVA.Sprint4.Task7.V12.Lib;
namespace Tyuiu.KonovalovVA.Sprint4.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 4;
            string st = "658932125478";
            int res = ds.Calculate(n, m, st);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}