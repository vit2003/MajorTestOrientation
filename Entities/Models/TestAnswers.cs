﻿using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Models
{
    public partial class TestAnswers
    {
        public TestAnswers()
        {
            TestResults = new HashSet<TestResults>();
            AnswerPGroups = new HashSet<AnswersPGroups>();
        }

        public int AnswerId { get; set; }
        public string AnswerContent { get; set; }
        public int QuestionId { get; set; }
        public int OrderIndex { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TestQuestions Question { get; set; }
        public virtual ICollection<TestResults> TestResults { get; set; }
        public virtual ICollection<AnswersPGroups> AnswerPGroups { get; set; }
    }
}
