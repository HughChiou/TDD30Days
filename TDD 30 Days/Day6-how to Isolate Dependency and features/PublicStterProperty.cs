using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_how_to_Isolate_Dependency_and_features
{
    /// <summary>
    /// 使用公開屬性設定相依性
    /// </summary>
    public class Validation2
    {
        public IAccountDao AccountDao { private get; set; }

        public IHash Hash { private get; set; }

        public bool CheckAuthentication(string id, string password)
        {
            if (this.AccountDao==null)
            {
                throw new ArgumentNullException();
            }

            if (this.Hash==null)
            {
                throw new ArgumentNullException();
            }

            string passwordByDao = this.AccountDao.GetPassword(id);
            string hashResult = this.Hash.GetHashResult(password);

            return passwordByDao == hashResult;
        }
    }
}
