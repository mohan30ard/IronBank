using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1
{
    public class AccountManager
    {
        private AccountDB accountDB;

        private static readonly Random random = new Random();
        private static List<int> generatedAccountNumbers = new List<int>();

        public AccountManager(AccountDB accountDB)
        {
            this.accountDB = accountDB;
        }

        public Dictionary<string, string> Users
        {
            get { return accountDB.Users; }
        }

        public List<Account> Accounts
        {
            get { return accountDB.GetAccounts(); }
        }

        public Account CreateAccount(string name, string address, string email, string phoneNumber, long ssn, string password, decimal initialBalance)
        {
            // Generate a new account number
            int accountNumber = GenerateAccountNumber();
            string userName = GenerateUserName(name,accountNumber);
            // Create a new account and save it in the data access layer
            Account newAccount = new Account(accountNumber, name, address, email, phoneNumber, ssn, userName, password, initialBalance);
            accountDB.SaveAccountDetails(newAccount);
            accountDB.SaveAccountCreationRequest(newAccount);
            return newAccount;
        }

        public void UpdateAccount(Account account)
        {
            accountDB.UpdateAccount(account);
        }

        public string Display(Account account)
        {
            return account.ToString();
        }

        public string AddtoListBox(Account account)
        {

            return "Name : "+account.Name.ToString() +" - "+"Account Number : "+account.AccountNumber.ToString() +" - "+"User Name : "+ account.Username.ToString() +" - "+"Locked : "+ account.IsLocked.ToString();
        }

        private string GenerateUserName(string name,int accountNumber)
        {
            string namePart = name.Substring(0, Math.Min(name.Length, 4));

            string accountNumberString = accountNumber.ToString();

            string accountNumberPart = accountNumberString.Substring(0, Math.Min(accountNumberString.Length, 4));

            if (namePart.Length < 4)
            {
                namePart = namePart.PadRight(4, '0');
            }

            string username = namePart + "_" + accountNumberPart;

            return username;

        }

        public void SubmitAccountDeletionRequest(Account account)
        {
            // Create a new account deletion request and submit it for admin approval
            Account deletionRequest = account;
            accountDB.SaveAccountDeletionRequest(deletionRequest);
        }

        public Account GetAccount(int userId)
        {
            // Retrieve account details from the data access layer
            return accountDB.GetAccountDetails(userId);
        }

        public void Deposit(int userId, decimal amount)
        {
            // Retrieve account details from the data access layer
            var account = accountDB.GetAccountDetails(userId);
            if (account == null)
            {
                throw new ApplicationException("Account not found.");
            }

            // Perform deposit operation
            account.Balance += amount;
            accountDB.UpdateAccount(account);
        }

        public void Withdraw(int userId, decimal amount)
        {
            
            var account = accountDB.GetAccountDetails(userId);
            if (account == null)
            {
                throw new ApplicationException("Account not found.");
            }

            
            if (account.Balance < amount)
            {
                throw new ApplicationException("Insufficient balance.");
            }

            
            account.Balance -= amount;
            accountDB.UpdateAccount(account);
        }

        private int GenerateAccountNumber()
        {
            int newAccountNumber;
            do
            {
                newAccountNumber = random.Next(1000000, 10000000);
            } while (generatedAccountNumbers.Contains(newAccountNumber));

            generatedAccountNumbers.Add(newAccountNumber);
            return newAccountNumber;
        }

        private void RemoveAccountNumber(int accountNumber)
        {
            generatedAccountNumbers.Remove(accountNumber);
        }

        public List<Account> ApprovalRequests
        {
            get { return accountDB.GetAccountCreationRequests(); }
        }

        public List<Account> DeletionRequests
        {
            get { return accountDB.GetAccountDeletionRequests(); }
        }

        public void ApproveAccountCreationRequest(Account account)
        {
            // Approve account creation request
            var existingAccount = accountDB.GetAccountCreationRequests().Find(acc => acc.AccountNumber == account.AccountNumber);
            if (existingAccount != null)
            {
                accountDB.AddUser(existingAccount.Username, existingAccount.Password);
                accountDB.UnLockAccount(existingAccount.AccountNumber);
                accountDB.GetAccountCreationRequests().Remove(existingAccount);
            }
        }

        public void RejectAccountCreationRequest(Account account)
        {
            // Reject account creation request
            var existingAccount = accountDB.GetAccountCreationRequests().Find(acc => acc.AccountNumber == account.AccountNumber);
            if (existingAccount != null)
            {
                accountDB.RemoveAccount(existingAccount.AccountNumber);
                RemoveAccountNumber(existingAccount.AccountNumber);
                accountDB.GetAccountCreationRequests().Remove(existingAccount);
            }
        }

        public void ApproveAccountDeletionRequest(Account account)
        {
            // Approve account deletion request
            var existingAccount = accountDB.GetAccountDeletionRequests().Find(acc => acc.AccountNumber == account.AccountNumber);
            if (existingAccount != null)
            {
                accountDB.RemoveAccount(existingAccount.AccountNumber);
                accountDB.RemoveUser(existingAccount.Username);
                RemoveAccountNumber(existingAccount.AccountNumber);
                accountDB.GetAccountDeletionRequests().Remove(existingAccount);
            }
        }

        public void RejectAccountDeletionRequest(Account account)
        {
            // Reject account deletion request
            var existingAccount = accountDB.GetAccountDeletionRequests().Find(acc => acc.AccountNumber == account.AccountNumber);
            if (existingAccount != null)
            {
                accountDB.GetAccountDeletionRequests().Remove(existingAccount);
            }
        }

        public bool IsAccountLocked(string userName)
        {
            // Check if account is locked
            var existingAccount = accountDB.GetAccountDetails(userName);
            if (existingAccount != null)
            {
                return existingAccount.IsLocked;
            }
            return false;
        }

        public List<Account> GetAccounts()
        {
            return accountDB.GetAccounts();
        }
    }
}
