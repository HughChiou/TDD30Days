using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day3_Write_a_Unit_TestTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Write_a_Unit_TestTests.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        #region 舊的測試
        //[TestMethod()]
        //public void CheckAuthenticationTest()
        //{
        //    //arrange
        //    Validation target = new Validation();
        //    string id = string.Empty;
        //    string password = string.Empty;

        //    //act
        //    bool expected = false;
        //    bool actual;
        //    actual = target.CheckAuthentication(id, password);

        //    //assert
        //    Assert.AreEqual(expected, actual);

        //}
        #endregion
        
        [TestMethod()]
        public void CheckAuthenticationTest()
        {
            //arrange
            IAccountDao dao = new StubAccountDao();
            IHash hash = new StubHash();
            Validation target = new Validation(dao, hash);
            string id = string.Empty;
            string password = string.Empty;

            //action
            bool expected = true;
            bool actual;
            actual = target.CheckAuthentication(id, password);

            //assert
            Assert.AreEqual(expected, actual);
        }

        private class StubAccountDao : IAccountDao
        {
            public string GetPassword(string id)
            {
                return "1111";
            }
        }

        private class StubHash : IHash
        {
            public string GetHashResult(string password)
            {
                return "1111";
            }
        }
    }
}