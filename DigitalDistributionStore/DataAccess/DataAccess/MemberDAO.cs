﻿using BusinessObject;
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
                    var check = context.Members.SingleOrDefault(m => m.Email == member.Email);
                    if(check == null)
                    {
                        context.Add(member);
                        context.SaveChanges();
                    }       
                    else
                    {
                        throw new Exception("This email has already existed!");
                    }
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
                    var check = context.Members.SingleOrDefault(m => m.Email == member.Email);
                    if(check == null)
                    {
                        context.Entry<Member>(member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                    }
                    else if(check.MemberID == member.MemberID)
                    {
                        check.MemberName = member.MemberName;
                        check.Password = member.Password;
                        check.Status = member.Status;
                        check.IsAdmin = member.IsAdmin;
                        context.Entry<Member>(check).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("This email has already existed!");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static List<Member> SearchByName(string search)
        {
            List<Member> list = null;
            try
            {
                
                using(var context = new DBContext())
                {
                    list = context.Members.Where(member => member.MemberName.Contains(search)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public static Member Login(string email, string password)
        {
            Member loginUser = null;
            try
            {
                using (var context = new DBContext())
                {
                    loginUser = context.Members.SingleOrDefault(member => member.Email == email && member.Password == password);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return loginUser;
        }
        public static void ChangeStatus(Member member)
        {
            try
            {
                using (var context = new DBContext())
                {
                    member.Status = !member.Status;
                    context.Entry<Member>(member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
