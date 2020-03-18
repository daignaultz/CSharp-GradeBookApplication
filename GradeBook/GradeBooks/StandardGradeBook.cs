﻿using System;
using System.Linq;
using GradeBook.GradeBooks;
using GradeBook.Enums;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool weight) : base(name, weight)
        {
            Type = GradeBookType.Standard;
        }
    }
}