﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.ChainOfResponsibility
{
    // Receiver
    public class User
    {
        public bool BankPayment { get; private set; }
        public bool RevolutPayment { get; private set; }
        public bool PayPalPayment { get; private set; }

        public User(bool bank, bool revolut, bool paypal)
        {
            BankPayment = bank;
            RevolutPayment = revolut;
            PayPalPayment = paypal;
        }
    }
}