using System;
namespace WWClassLib.Engine
{
    public class WeatherToOutfitEngine
    {


        public string Bottom;
        public string Top;
        public string Jacket;
        public string Shoes;
        public string Accessories;
        public string Other;


        public WeatherToOutfitEngine()
        {

        }

        public void ClearOutfitPrediction()
        {
            Bottom = string.Empty;
            Top = string.Empty;
            Jacket = string.Empty;
            Shoes = string.Empty;
            Accessories = string.Empty;
            Other = string.Empty;
        }

        public void RunEngine(WWClassLib.Models.Forecast.RootObject data)
        {
            int fahrenheit;
            if (int.TryParse(data.forecast.simpleforecast.forecastday[0].high.fahrenheit, out fahrenheit))
            {

                if (fahrenheit >= 70)
                {
                    Bottom = "shorts/skirt";
                }
                else if (fahrenheit >= 30)
                {
                    Bottom = "pants";
                }
                else if (fahrenheit < 30)
                {
                    Bottom = "snow pants";
                }
            }



        }



    }
}

