using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Interfaces
{
    public interface ILicense : IShoppingItem
    {
        int NumberOfLicenses { get; set; }
    }
}
