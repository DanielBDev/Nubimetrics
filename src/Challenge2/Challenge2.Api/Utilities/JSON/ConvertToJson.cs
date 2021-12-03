using Newtonsoft.Json;

namespace Challenge2.Api.Utilities.JSON
{
    public class ConvertToJson : IJsonConvert
    {
        public void Convert<T>(T value)
        {
            string json = JsonConvert.SerializeObject(value);

            System.IO.File.WriteAllText("Json/currency.json", json);
        }
    }
}