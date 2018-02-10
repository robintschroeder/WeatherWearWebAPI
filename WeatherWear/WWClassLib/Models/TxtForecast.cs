using System;

namespace WWClassLib.Models
{
    public class TxtForecast
    {
        public TxtForecast()
        {
            //constructor
        }

        public long Fctext { get; set; }
        public long Fcttext_metric { get; set; }
        public long Icon { get; set; }
        public long Icon_url { get; set; }
        public long Period { get; set; }
        public long Pop { get; set; }
        public long Title { get; set; }
    }
}