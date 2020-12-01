using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Banking;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace BankingAppSH.Services
{
    class BankingDatabase
    {
        private SQLiteConnection _database;

        public BankingDatabase()

        {
            var path = GetDbPath();
            _database = new SQLiteConnection(path);

            _database.CreateTable<Bank>();
            _database.CreateTable<Customer>();
            _database.CreateTable<BankAccount>();
            _database.CreateTable<Transaction>();
        }
        public string GetDbPath()
        //_database = new SQLiteConnection()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "banking.db");
            return path;
        }
        public void SeedDatabase()
        {
            if (_database.Table<Bank>().Count == 0)
            {


                Bank fnb = new Bank("First National Bank", 4324, "Kenilworth");

                Customer myNewCustomer = new Customer("7766445424", "10 me at home", "Bob", "The Builder");

                fnb.AddCustomer(myNewCustomer);

                _database.Insert(myNewCustomer);
                _database.Insert(fnb);
                _database.UpdateWithChildren(fnb);

                var account = myNewCustomer.ApplyForBankAccount();
                _database.Insert(account);
                _database.UpdateWithChildren(myNewCustomer);


            }
        }

        public Customer GetCustomerByIdNumber(string saIdNumber)
        {
            return _database.Table<Customer>().Where(X => X.IdNumber == saIdNumber).
            }

        public List<Transaction> Transactions GetTransactions(BankAccount account)
        {
            _database.Table<Transaction>().Where(x => x.BankAccountId == account.BankAcount).ToList(); )
        }
        public List<Transaction> Transactions GetCurrentAccount(Customer customer)
        {
            _database.Table<Transaction>().Where(x => x.BankAccountId == )
        }

    }
}
