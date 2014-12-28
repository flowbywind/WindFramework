using System;
using System.Collections.Generic;
using Wind.Account.Contract;
using Wind.Core.Cache;
using Wind.Core.Service;


namespace Wind.Web
{
    public class ServiceContext
    {
        public static ServiceContext Current
        {
            get
            {
                return CacheHelper.GetItem<ServiceContext>("ServiceContext", () => new ServiceContext());

            }
        }

        public IAccountService AccountService {
            get {
                return ServiceHelper.CreateService<IAccountService>();
            }
        }

        //public ICmsService CmsService
        //{
        //    get
        //    {
        //        return ServiceHelper.CreateService<ICmsService>();
        //    }
        //}

        //public ICrmService CrmService
        //{
        //    get
        //    {
        //        return ServiceHelper.CreateService<ICrmService>();
        //    }
        //}

        //public IOAService OAService
        //{
        //    get
        //    {
        //        return ServiceHelper.CreateService<IOAService>();
        //    }
        //}
    }
}
