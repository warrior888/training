﻿using System;
using Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch;

namespace Toci.DevelopersLeasing.Bll.CoursesSearch
{
    public class ProgrammingCoursesEndDateSearchParams : IEndDateSearchParams
    {
        public string Topic { get; set; }
        public string Instructor { get; set; }
        public int? Level { get; set; }
        public DateTime? Start { get; set; }
    }
}