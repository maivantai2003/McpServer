using ModelContextProtocol.Server;
using System.ComponentModel;
namespace McpServer.Tools
{
    [McpServerToolType]
    public static class WeatherTool
    {
        [McpServerTool]
        [Description("Gets the weather for a specified city.")]
        public static string GetWeather([Description("City is searched for weather information.")]string city)
        {
            return $"The weather in {city} is sunny with a temperature of 25°C.";
        }
        [McpServerTool,Description("Echo the input message back")]
        public static string Echo([Description("Message to echo back.")]string message)
        {
            return $"Echo: {message}";
        }
        [McpServerTool,Description("Get the current date and time.")]
        public static string GetCurrentDateTime()
        {
            return $"Current date and time: {DateTime.Now}";
        }
        
    }
}
