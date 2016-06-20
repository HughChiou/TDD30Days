using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_how_to_Isolate_Dependency_and_features
{
    public class Validation3
    {
        /// <summary>
        /// 呼叫方法時傳入建構參數
        /// </summary>
        /// <param name="accountDao"></param>
        /// <param name="hash"></param>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckAuthentication(IAccountDao accountDao, IHash hash, string id, string password)
        {
            var passwordByDao = accountDao.GetPassword(id);
            var hashResult = hash.GetHashResult(password);

            return passwordByDao == hashResult;
        }
    }
}
