﻿using System;
using System.Collections.Generic;
using System.Text;

namespace problem8
{
    class Sequence
    {
        private static int currentValue = 0;
        private Sequence()
        {
        }
        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
}
