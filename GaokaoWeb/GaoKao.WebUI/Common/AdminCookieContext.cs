using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wind.Core.Cache;
using Wind.Framework.Utility;
using Wind.Web;
namespace GaoKao.WebUI.Common
{
    public class AdminCookieContext : CookieContext
    {
        public static AdminCookieContext Current
        {
            get
            {
                return CacheHelper.GetItem<AdminCookieContext>();
            }
        }

        public override string KeyPrefix
        {
            get
            {
                return Fetch.ServerDomain + "_AdminContext_";
            }
        }
    }
}
