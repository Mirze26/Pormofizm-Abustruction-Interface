using HomeWork.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Service
{
    internal class AccountService : IAccountService
    {
        public void Login(string UserName, string PassWord)
        {
            if (UserName == "Cavid123" && PassWord == "Cavid1993")
            {
                Console.WriteLine("Giris Uqurludur");
           
            }
            else
            {
                Console.WriteLine("Emailve ya Password sehvdir");
            }
        }    
	}
    
}
