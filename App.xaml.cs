using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BankingAppSH
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
       /* public void Information()
        {
            Customer myNewCustomer = new Customer("7766445424", "10 me at home", "Bob", "The Builder");
        }*/
        
        protected void Deposit_Clicked()
        {
           /* var account = myNewCustomer.ApplyForBankAccount();
            account.DepositMoney(1500, DateTime.Now, "Stipend");*/
            decimal amount;
            string description;
        }

        protected  void WithdrawMoneyButton_Clicked()
        {
            //var account = myNewCustomer.ApplyForBankAccount();
            //account.DepositMoney(1500, DateTime.Now, "Stipend");
            decimal amount;
            string description;
        }

        protected  void TransactionHistoryButton_Clicked()
        {
            //var account = myNewCustomer.ApplyForBankAccount();
           // var history = account.GetTransactionHistory();
        }
    }
}
