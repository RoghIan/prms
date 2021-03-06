﻿using System;

namespace API.DTO
{
    public class ReportToReturnDto
    {
        public DateTime ReportDate { get; set; }
        public int Placements { get; set; }
        public int VideoShowings { get; set; }
        public int Hours { get; set; }
        public int ReturnVisits { get; set; }
        public int BibleStudies { get; set; }
        public int Remarks { get; set; }
        public string TitleName { get; set; }
        public string GroupName { get; set; }
        public bool Auxiliary { get; set; }
        public FlatPublisherToReturnDto Publisher { get; set; }
        public int PublisherId { get; set; }
    }
}