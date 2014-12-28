using System;
using System.Linq;
using Wind.Framework.Contract;
using System.Collections.Generic;
using Wind.Framework.Utility;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wind.Account.Contract
{
    [Serializable]
    [Table("VerifyCode")]
    public class VerifyCode : ModelBase
    {
        public Guid Guid { get; set; }
        public string VerifyText { get; set; }
    }

}



