﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AntMe.Factions.Ants
{
    [AttributeUsage(
        AttributeTargets.Class, 
        AllowMultiple=false, 
        Inherited=true
    )]
    public abstract class CasteAttribute : Attribute
    {
    }
}