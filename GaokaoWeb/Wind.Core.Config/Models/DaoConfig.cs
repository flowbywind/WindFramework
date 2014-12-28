using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wind.Core.Config
{
    /// <summary>
    /// 数据库配置
    /// </summary>
    [Serializable]
    public class DaoConfig : ConfigFileBase
    {
        public DaoConfig()
        {
        }
        #region 序列化属性
        public String GaoKao { get; set; }
        public String Log { get; set; }
        public String Account { get; set; }
        #endregion
    }
}
