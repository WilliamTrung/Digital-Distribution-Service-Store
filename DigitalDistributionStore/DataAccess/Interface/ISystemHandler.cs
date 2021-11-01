using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface ISystemHandler
    {
        public Member Login(string email, string password) => MemberDAO.Login(email, password);

        
    }
}
