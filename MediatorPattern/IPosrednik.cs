﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public interface IPosrednik
    {
        void Obavesti(object posiljalac, string dogadjaj);
    }
}

