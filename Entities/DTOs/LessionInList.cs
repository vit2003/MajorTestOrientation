﻿namespace Entities.DTOs
{
    public class LessionInList
    {
        public int LessionId { get; set; }
        public string Description { get; set; }
        public Majors Major { get; set; }
        public string Link { get; set; }
        public string ImageUrl { get; set; }
    }

    public class Majors
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
