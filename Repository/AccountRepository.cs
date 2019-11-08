using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Entities.Extensions;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Account> AccountsByOwnerAsync(Guid ownerId)
        {
            return FindByCondition(a => a.OwnerId.Equals(ownerId));
        }

        public async Task CreateAccountAsync(Account account)
        {
            account.AccountId = Guid.NewGuid();
            Create(account);
            await SaveAsync();
        }

        public async Task DeleteAccountAsync(Account account)
        {
            Delete(account);
            await SaveAsync();
        }

        public async Task<Account> GetAccountByIdAsync(Guid accountId)
        {
            return await FindByCondition(account => account.AccountId.Equals(accountId)).DefaultIfEmpty(new Account()).SingleAsync();
        }

        public async Task<IEnumerable<Account>> GetAllAccountsAsync()
        {
            return await FindAll().OrderBy(ac => ac.DateCreated).ToListAsync();
        }

        public async Task UpdateAccountAsync(Account dbAccount, Account account)
        {
            dbAccount.Map(account);
            Update(dbAccount);
            await SaveAsync();
        }
    }
}