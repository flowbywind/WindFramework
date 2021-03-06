﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GaoKao.WebUI.Models {
    public class GaoKaoContext : DbContext {
        public GaoKaoContext()
            : base("DefaultConnection") {
        }
        public DbSet<Model.Answer> Answer { get; set; }
        public DbSet<Model.ExamPaper> ExamPaper { get; set; }
        public DbSet<Model.Knowledge> Knowledge { get; set; }
        public DbSet<Model.Question> Question { get; set; }
        public DbSet<Model.QuestionItem> QuestionItem { get; set; }
        public DbSet<Model.UserInfo> UserInfo { get; set; }
    }
}