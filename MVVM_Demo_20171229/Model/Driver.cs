using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVM_Demo_20171229.Model
{
    public class Driver
    {
        public string Name { get; set; }
        public string Mfg { get; set; }
        public string Date { get; set; }
        public string Version { get; set; }
        public Driver()
        {

        }

        public Driver(String name, String mfg, String date, String version)
        {
            Name = name;
            Mfg = mfg;
            Date = date;
            Version = version;
        }
    }
}
