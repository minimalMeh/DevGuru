using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.Facade
{
    public static class Client
    {
        public static void Operation(Facade facade)
        {
            facade.Operation();
        }
    }
}
