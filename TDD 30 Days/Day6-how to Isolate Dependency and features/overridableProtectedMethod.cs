using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_how_to_Isolate_Dependency_and_features
{
    public class Validation
    {
        public bool CheckAuthentication(string id, string password)
        {
            var accountDao = GetAccountDao();
            var passwordByDao = accountDao.GetPassword(id);

            var hash = new Hash();
            var hashResult = hash.GetHashResult(password);

            return passwordByDao == hashResult;
        }

        protected virtual Hash GetHash()
        {
            return new Hash();
        }

        protected virtual AccountDao GetAccountDao()
        {   
            return new AccountDao(); ;
        }

        public class AccountDao
        {
            public virtual string GetPassword(string id)
            {
                return "123";
            }
        }

        public class Hash
        {
            public virtual string GetHashResult(string password)
            {
                return "123";
            }
        }

        public class MyValidation : Validation
        {
            protected override AccountDao GetAccountDao()
            {
                return new StubAccountDao();
            }

            protected override Hash GetHash()
            {
                return new StubHash();
            }

            public class StubAccountDao : AccountDao
            {
                public override string GetPassword(string id)
                {
                    return "91";
                }
            }

            public class StubHash : Hash
            {
                public override string GetHashResult(string password)
                {
                    return "91";
                }
            }
        }
    }
}
