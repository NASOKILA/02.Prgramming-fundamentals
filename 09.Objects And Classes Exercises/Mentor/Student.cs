﻿namespace Mentor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public string Name { set; get; }

        public List<string> Comments { set; get; }

        public List<DateTime> Dates { set; get; }
    }
}
