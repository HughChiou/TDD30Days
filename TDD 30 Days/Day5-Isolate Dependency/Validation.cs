using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Day3_Write_a_Unit_TestTests
{
    public class Validation
    {
        private IAccountDao _accountDao;
        private IHash _hash;

        public Validation(IAccountDao dao, IHash hash)
        {
            this._accountDao = dao;
            this._hash = hash;
        }

        public bool CheckAuthentication(string id, string password)
        {
            var passwordByDao = this._accountDao.GetPassword(id);

            var hashResult = this._hash.GetHashResult(password);

            return passwordByDao == hashResult;

            #region 原本的寫法
            //AccountDao dao = new AccountDao();
            //var passwordByDao = dao.GetPassword(id);

            //Hash hash = new Hash();
            //var hashResult = hash.GetHashResult(password);

            //return passwordByDao == hashResult;
            #endregion
        }
    }

    public interface IAccountDao
    {
        string GetPassword(string id);
    }

    public class AccountDao : IAccountDao
    {
        public string GetPassword(string id)
        {
            //連接DB
            throw new NotImplementedException();
        }
    }

    public interface IHash
    {
        string GetHashResult(string password);
    }

    public class Hash : IHash
    {
        public string GetHashResult(string password)
        {
            //使用SHA512加密
            throw new NotImplementedException();
        }
    }
}
