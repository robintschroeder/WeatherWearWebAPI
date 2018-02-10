using System;
namespace WWClassLib.Models
{
    public class SimpleForecast
    {

        public SimpleForecast()
        {
            //constructor
        }

        public long DateEpoch { get; set; }
            public DateTime DatePretty { get; set; }
            public int DateDay { get; set; }
            public int DateMonth { get; set; }
            public int DateYear { get; set; }
            public int DateYday { get; set; }
            public int DateHour { get; set; }
            public int DateMin { get; set; }
            public int DateSec { get; set; }
            public int DateIsdst { get; set; }
            public string dateMonthname { get; set; }
            public string dateWeekday_short { get; set; }
            public string dateWeekday { get; set; }
            public string dateAmpm { get; set; }
            public string dateTz_short { get; set; }
            public string dateTz_long { get; set; }
            public int Period { get; set; }
            public int High { get; set; }
            public int Low { get; set; }
            public string Conditions { get; set; }
            public string Icon { get; set; }
            public string Icon_url { get; set; }
            public string Skyicon { get; set; }
            public int Pop { get; set; }
            public string Qpf_allday { get; set; }
            public string Qpf_day { get; set; }
            public string Qpf_night { get; set; }
            public string Snow_allday { get; set; }
            public string Snow_day { get; set; }
            public string Snow_night { get; set; }
            public int Maxwind { get; set; }
            public int Avewind { get; set; }
            public int Avehumidity { get; set; }
            public int Maxhumidity { get; set; }
            public int Minhumidity { get; set; }
        }
    }

