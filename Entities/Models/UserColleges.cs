﻿namespace Entities.Models
{
    public class UserColleges
    {
        public int UserId { get; set; }
        public int CollegeId { get; set; }
        public bool IsConnector { get; set; }

        public virtual SysUser User { get; set; }
        public virtual Colleges College { get; set; }
    }
}
