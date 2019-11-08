using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAccountRepository 
    {
        IEnumerable<Account> AccountsByOwnerAsync(Guid ownerId);
        Task<IEnumerable<Account>> GetAllAccountsAsync();
        Task<Account> GetAccountByIdAsync(Guid accountId);
        Task CreateAccountAsync(Account account);
        Task UpdateAccountAsync(Account dbAccount, Account account);
        Task DeleteAccountAsync(Account account);
    }
}
