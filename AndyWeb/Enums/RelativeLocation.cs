﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AndyWeb
{
    public enum RelativeLocation
    {
        NotSpecified = -1,
        VeryClose = 0,
        Close = 25,
        Center = 50,
        Far = 75,
        VeryFar = 100
    }
}