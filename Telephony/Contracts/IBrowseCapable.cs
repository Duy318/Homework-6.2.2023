using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Contracts
{
    public interface IBrowseCapable
    {
        void Browse(string websiteURL);
    }
}