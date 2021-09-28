using System;
using System.Collections.Generic;
using System.Text;

namespace HW2_Practice_Fullfill
{
    public class FulfillData
    {
        public string State { get; set; }
        public string Gender { get; set; }
        public double Mean { get; set; }
        public string N { get; set; }

        public FulfillData()
        {
            State = string.Empty;
            Gender = string.Empty;
            Mean = 0;
            N = string.Empty;
        }

    }
}
