using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model {
    public class QuestionItem {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 选项key A/B/C/D
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 选项内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 课程ID
        /// </summary>
        public int CourseID { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public int CreatedTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public int ModifiedTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreatedPerson { get;set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string ModifiedPerson{get;set;}

    }
}
