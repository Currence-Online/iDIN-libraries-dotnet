using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankId.Merchant.Library
{
    public class SamlAttributesEncryptionKey
    {
        public string AttributeName { get; set; }
        public byte[] AesKey { get; set; }
    }
}
