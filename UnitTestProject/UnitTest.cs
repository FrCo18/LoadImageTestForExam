using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        LaboratoryEntities db = new LaboratoryEntities();

        [TestMethod]
        public void checkUser()
        {
            string login = "nmably1";
            string password = "ukM0e6";
            var users = db.Users.Where(
                u => u.login == login && u.password == password
                ).ToList();

            Assert.AreEqual(1, users.Count());
        }
    }
}
