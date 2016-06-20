using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Stub_Mock_Fake_synopsis
{
    public interface ICheckInFee
    {
        decimal GetFee(Customer customer);
    }

    public class Customer
    {
        public bool IsMale { get; set; }

        public int Seq { get; set; }
    }

    public class Pub
    {
        private ICheckInFee _checkInFee;
        private decimal _inCome = 0;

        public Pub(ICheckInFee checkInFee)
        {
            this._checkInFee = checkInFee;
        }

        public int CheckIn(List<Customer> customers)
        {
            var result = 0;

            foreach (var customer in customers)
            {
                var isFemale = !customer.IsMale;

                if (isFemale)
                {
                    continue;
                }
                else
                {
                    this._inCome += this._checkInFee.GetFee(customer);

                    result++;
                }
            }

            return result;
        }

        public decimal GetInCome()
        {
            return this._inCome;
        }
    }
}
