﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DigitsRecognizer
{
    public interface IDistance
    {
        double Between(int[] pixels1, int[] pixels2);
    }
}
