using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model {
    /// <summary>
    /// 考点表
    /// </summary>
    public class Knowledge {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 父ID
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 课程类型
        /// </summary>
        public int CourseType { get; set;}
        /// <summary>
        /// 考点内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 课程ID
        /// </summary>
        public int CourseID { get; set; }
        /// <summary>
        /// 考点级别 1 2 3
        /// </summary>
        public int Level { get; set; }
    }
}
