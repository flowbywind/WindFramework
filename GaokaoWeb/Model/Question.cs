using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model {
    public  class Question {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 题号
        /// </summary>
        public int Num { get; set; }
        /// <summary>
        /// 知识点
        /// </summary>
        public int KnowledateID { get; set; }
        /// <summary>
        /// 课程类型 
        /// </summary>
        public int CourseType { get; set; }
        /// <summary>
        /// 题目
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 试卷ID
        /// </summary>
        public int PaperID { get; set; }
        /// <summary>
        /// 课程ID
        /// </summary>
        public int CourseID { get; set; }
        /// <summary>
        /// 是否单选 1：单选2：多选
        /// </summary>
        public int IsSingle { get; set; }
        /// <summary>
        /// 题目类型 1、选择题 3.阅读理解4：古诗文 5、计算题 6
        /// </summary>
        public string QuestionType { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public int CreatedTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public int ModifiedTime { get; set;}
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreatedPerson { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string ModifiedPerson { get; set; }
    }
}
