using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model {
    /// <summary>
    /// 试卷表
    /// </summary>
    public class ExamPaper {
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 试卷名称
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 课程ID
        /// </summary>
        public int CourseID { get; set; }
        /// <summary>
        /// 难度
        /// </summary>
        public int Difficulty { get; set; }
        /// <summary>
        /// 判断模拟 和真题  1：模拟2：真题
        /// </summary>
        public string Type { get; set; }
    }
}
