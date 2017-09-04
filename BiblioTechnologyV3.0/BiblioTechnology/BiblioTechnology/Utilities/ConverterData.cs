using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechnology.Utilities
{
    class ConverterData
    {
        public string converterData(DateTime data)
        {
            return data.Year.ToString() + "-" + data.Month.ToString() + "-" + data.Day.ToString() + " " + data.ToLongTimeString()+".000";
        }
    }
}
