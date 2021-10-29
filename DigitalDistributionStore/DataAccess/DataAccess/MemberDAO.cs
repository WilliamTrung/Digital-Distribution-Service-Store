using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class MemberDAO
    {
        public static List<Member> GetMembers()
        {
            var ListMember = new List<Member>();
            try
            {
                using (var context = new DBContext())
                {
                    ListMember = context.Members.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return ListMember;
        }
        public static void AddNew(Member member)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Add(member);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remove(Member member)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Remove(member);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Update(Member member)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Entry<Member>(member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
