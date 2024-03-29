﻿using System;

namespace Entities.RequestFeature
{
    public class UpdateProfileInfo
    {
        public string FullName { get; set; }
        public bool? Gender { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDay { get; set; }
        public string ImagePath { get; set; }
    }
}
