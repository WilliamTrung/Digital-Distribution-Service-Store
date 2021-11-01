using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface IMember
    {
        public List<Member> GetMembers();
        public void Insert(Member member);
        public void Update(Member member);
        public void Delete (Member member);
        public List<Member> SearchByName(Member member);
    }
}
