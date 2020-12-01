using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Banking;
using BankingAppSH.Services;

namespace BankingAppSH
{
    public partial class MainPage : ContentPage
    {
       private BankAccount _account;

        private BankingDatabase _bankingDatabase;
        public MainPage()
        {

            InitializeComponent();

        }
            Bank fnb = new Bank("First National Bank", 4324, "Kenilworth");

            Customer myNewCustomer = new Customer("7766445424", "10 me at home", "Bob", "The Builder");

            fnb.AddCustomer(myNewCustomer);



            var account = myNewCustomer.ApplyForBankAccount();

            account.DepositMoney(1500, DateTime.Now, "Stipend");



        }


        private void DMoneyButton_Clicked(object sender, EventArgs e)
        {
            decimal EnterDepositAmount = 0;
            string description = EnterDepositDescription.Text.ToString();
            _account.DepositMoney(EnterDepositAmount, DateTime.Now,  description);
           


        }

        private void WMoneyButton_Clicked(object sender, EventArgs e)
        {
           
            decimal EnterWithdrawAmount = 0;
            string description = EnterDescription.Text.ToString();
            _account.WithdrawMoney(EnterWithdrawAmount, DateTime.Now, description);
        }

        private void THistoryButton_Clicked(object sender, EventArgs e)
        {
            var history = _account.GetTransactionHistory();
            TransactionHistoryButton.Text = history; 
        }
    }

}
