﻿using System.Collections.Generic;

namespace Entities.DTOs
{
    public class HollandQuestion
    {
        public int Id { get; set; }
        public string content { get; set; }
        public int Indext { get; set; }
        public List<AnswerInTest> Answers { get; set; }
    }
}
