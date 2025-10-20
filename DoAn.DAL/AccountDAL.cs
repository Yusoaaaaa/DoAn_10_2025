using DoAn.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAL
{
    public class AccountDAL
    {
        public ACCOUNT GetAccount(string email, string password)
        {
            using (var db = new AccountDB())
            {
                return db.ACCOUNTs.FirstOrDefault(
                    a => a.EMAIL == email && a.MK_TK == password
                );
            }
        }
    }
}
