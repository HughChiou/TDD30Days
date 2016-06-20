using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day3_Write_a_Unit_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Write_a_Unit_Test.Tests
{
    [TestClass()]
    public class CaculatorTests
    {
        /// <summary>
        /// ADD的測試
        /// </summary>
        [TestMethod()]
        public void AddTest()
        {
            Calculator target = new Calculator();
            int firstNumber = 0;
            int secondNumber = 0;
            int expected = 0;
            int actual = 0;
            actual = target.Add(firstNumber, secondNumber);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("驗證這個方法的正確性");
        }

        [TestMethod()]
        public void AddTest1()
        {
            Calculator target = new Calculator();
            int firstNumber = 1;
            int secondNumber = 2;
            int expected = 3;
            int actual = 0;
            actual = target.Add(firstNumber, secondNumber);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("驗證這個方法的正確性");
        }

        [TestMethod()]
        public void Minus_Input_First_3_Second_2_Return_1()
        {
            //arrange
            Calculator target = new Calculator();
            int firstNumber = 3;
            int secondNumber = 2;
            int expected = 1;
            
            //act
            int actual;
            actual = target.Minus(firstNumber, secondNumber);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
