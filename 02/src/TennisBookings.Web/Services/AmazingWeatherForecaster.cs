using TennisBookings.Web.External.Models;

namespace TennisBookings.Web.Services {
    public class AmazingWeatherForecaster : IWeatherForecaster {
        public WeatherResult GetCurrentWeather() {
            // Do something amazig here
            return new WeatherResult { 
                WeatherCondition = WeatherCondition.Sun
            };
        }
    }
}