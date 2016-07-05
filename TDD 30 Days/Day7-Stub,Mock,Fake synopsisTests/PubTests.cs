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
      public void GetInComeTest() {
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

      [TestMethod]
      public void Test_CheckIn_Charge_Only_Male() {
         //arrange mock
         var customers = new List<Customer>();

         //2男1女
         var customer1 = new Customer { IsMale = true };
         var customer2 = new Customer { IsMale = true };
         var customer3 = new Customer { IsMale = false };

         customers.Add(customer1);
         customers.Add(customer2);
         customers.Add(customer3);

         MockRepository mock = new MockRepository();
         ICheckInFee stubCheckInFee = mock.StrictMock<ICheckInFee>();

         using (mock.Record()) {
            //期望呼叫ICheckInFee的GetFee()次數為2次
            stubCheckInFee.GetFee(customer1);

            LastCall
               .IgnoreArguments()
               .Return((decimal)100)
               .Repeat.Times(2);
         }

         using (mock.Playback()) {
            var target = new Pub(stubCheckInFee);

            var count = target.CheckIn(customers);
         }
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