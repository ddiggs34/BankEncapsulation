﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {

        //properties
        public string name {  get; set; }   

            
      //private field that we "cant see" to call in regular class (Program.cs)
      private double _balance;

        //access to private field
        public void Deposit(double amount)
        {
            _balance += amount; //this is saying that the BALANCE is going to be equal to or ADD to the 'amount' 
        }

       
        public double GetBalance() 
        
        { 
            return _balance;
        }

       

        
        
        
    }

    



}