using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day6_how_to_Isolate_Dependency_and_features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day6_how_to_Isolate_Dependency_and_features.Validation;

namespace Day6_how_to_Isolate_Dependency_and_features.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        public void CheckAuthenticationTest()
        {
            Validation target = new MyValidation();

            string id = "id隨便啦";
            string password = "密碼也沒關係";

            bool expected = true;

            bool actual;
            actual = target.CheckAuthentication(id, password);

            Assert.AreEqual(expected, actual);
        }
    }
}