using BusinessObject;
using DataAccess.Repository;
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
        public IMember Members() => new MemberRepository();
        public ICategory Categories() => new CategoryRepository();
        public IOrder Orders() => new OrderRepository();
        public IProduct Products() => new ProductRepository();
        public IOrderDetail OrderDetails() => new OrderDetailRepository();
    }
}
