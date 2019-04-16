using SelfBlog.Entities;
using System;
using System.Linq;

namespace SelfBolg.Services
{
    public interface IAccountService
    {
        AccountEntity Login(AccountEntity entity);

        AccountEntity Get(int id);
    }
    public class AccountService : IAccountService
    {
        private BlogDBContext _context = new BlogDBContext();
        public AccountEntity Get(int id)
        {
            return _context.Account.Where(u => u.Id == id).FirstOrDefault();
        }

        public AccountEntity Login(AccountEntity entity)
        {
            AccountEntity account = _context.Account.Where(s => s.Account == entity.Account).FirstOrDefault();
            if (account == null || account.Pwd != entity.Pwd)
                return null;
            return account;
        }
    }
}
