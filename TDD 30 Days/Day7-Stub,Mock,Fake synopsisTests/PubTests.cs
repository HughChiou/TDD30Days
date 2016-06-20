using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day7_Stub_Mock_Fake_synopsis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Mocks;

namespace Day7_Stub_Mock_Fake_synopsis.Tests
{
    [TestClass()]
    public class PubTests
    {
        [TestMethod()]
        public void GetInComeTest()
        {
            //arrange
            ICheckInFee stubCheckInFee = MockRepository.GenerateStub<ICheckInFee>();
            Pub target = new Pub(stubCheckInFee);

            stubCheckInFee.Stub(x => x.GetFee(Arg<Customer>.Is.Anything)).Return(100);

            var customers = new List<Customer>
            {
                new Customer {IsMale=true },
                new Customer {IsMale=true },
                new Customer {IsMale=false }
            };

            var inComeBeforeCheckIn = target.GetInCome();
            Assert.AreEqual(0, inComeBeforeCheckIn);

            decimal expectedIncome = 200;

            //act
            var chargeCustomerCount = target.CheckIn(customers);

            var actualIncome = target.GetInCome();

            //assert
            Assert.AreEqual(expectedIncome, actualIncome);

        }

        //fake的部分不能做…要企業版才有

        //[TestMethod()]
        //public void Test_Friday_Charge_Customer_Count()
        //{
        //    using (ShimsContext.Create())
        //    {

        //    }
        //}
    }
}