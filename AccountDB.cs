using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1
{
    public class AccountDB
    {
        private List<Account> accounts = new List<Account>();
        private List<Account> creationRequests = new List<Account>();
        private List<Account> deletionRequests = new List<Account>();
        private Dictionary<string, string> users = new Dictionary<string, string>
        {
            {"admin", "admin123" },
            {"user", "user123" }
        };

        public Dictionary<string, string> Users
        {
            get { return users; }
        }

        public Dictionary<string, string> AddUser(string username, string password)
        {
            users.Add(username, password);
            return users;
        }

        public Dictionary<string, string> RemoveUser(string username)
        {
            users.Remove(username);
            return users;
        }

        public void SaveAccountDetails(Account account)
        {
            // Save account details
            accounts.Add(account);
        }

        public Account GetAccountDetails(int accountNumber)
        {
            // Retrieve account details by user ID
            return accounts.Find(acc => acc.AccountNumber == accountNumber);
        }

        public void SaveAccountCreationRequest(Account account)
        {
            creationRequests.Add(account);
        }

        public List<Account> GetAccountCreationRequests()
        {
            return creationRequests;
        }

        public List<Account> GetAccountDeletionRequests()
        {
            return deletionRequests;
        }

        // Method to save account deletion request
        public void SaveAccountDeletionRequest(Account account)
        {
            deletionRequests.Add(account);
        }

        public void UpdateAccount(Account account)
        {
            // Update account details
            var existingAccount = accounts.Find(acc => acc.AccountNumber == account.AccountNumber);
            if (existingAccount != null)
            {
                existingAccount.Balance = account.Balance;
            }
        }

        public void RemoveAccount(int accountNumber)
        {
            // Remove account
            var existingAccount = accounts.Find(acc => acc.AccountNumber == accountNumber);
            if (existingAccount != null)
            {

                accounts.Remove(existingAccount);
            }
        }

        public void UnLockAccount(int accountNumber)
        {
            // Unlock account
            var existingAccount = accounts.Find(acc => acc.AccountNumber == accountNumber);
            if (existingAccount != null)
            {
                existingAccount.IsLocked = false;
            }
        }

        public Account GetAccountDetails(string username)
        {
            // Retrieve account details by username
            return accounts.Find(acc => acc.Username == username);
        }
    }
}
