﻿using System;
using System.Collections.Generic;

namespace API_Mission10.Models;

public partial class ZtblWeek
{
    public DateOnly WeekStart { get; set; }

    public DateOnly? WeekEnd { get; set; }
}
