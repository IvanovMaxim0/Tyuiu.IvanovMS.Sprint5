using Tyuiu.IvanovMS.Sprint5.Task0.V3.Lib;
namespace Tyuiu.IvanovMS.Sprint5.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\colla\source\repos\Tyuiu.IvanovMS.Sprint5\Tyuiu.IvanovMS.Sprint5.Task0.V3\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
