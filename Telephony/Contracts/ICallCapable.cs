using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Contracts
{
    public interface ICallCapable
    {
        void Call(string phoneNumber);
    }
}