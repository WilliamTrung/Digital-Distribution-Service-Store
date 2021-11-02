using BusinessObject;
using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMember
    {
        public void ChangeStatus(Member member) => MemberDAO.ChangeStatus(member);

        public void Delete(Member member) => MemberDAO.Remove(member);

        public List<Member> GetMembers() => MemberDAO.GetMembers();

        public void Insert(Member member) => MemberDAO.AddNew(member);

        public List<Member> SearchByName(string search) => MemberDAO.SearchByName(search);


        public void Update(Member member) => MemberDAO.Update(member);
    }
}
