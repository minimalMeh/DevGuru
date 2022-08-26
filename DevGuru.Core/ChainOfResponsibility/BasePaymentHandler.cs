using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.ChainOfResponsibility
{
    public abstract class BasePaymentHandler
    {
        protected BasePaymentHandler Next { get; set; }
        public abstract void Handle(User user);
    }
}
