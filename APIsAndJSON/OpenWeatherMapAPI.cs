using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void WeatherMapAPI()
        {
            var client = new HttpClient();

            var key = "a928eb068983835c87885cbe7fa6612b";
            

            while (true)
            {
                Console.WriteLine("Please enter a city name for the tempture");
                var cityName = Console.ReadLine();
                Console.WriteLine();

                var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={key}&units=imperial";
                var response = client.GetStringAsync(weatherURL).Result;
                var formattedResponse = JObject.Parse(response).GetValue("main").ToString();
                var temp = JObject.Parse(formattedResponse).GetValue("temp");

                Console.WriteLine($"The current tempture is {temp} degrees Fahrenheit");
            }


        }





    }
}
