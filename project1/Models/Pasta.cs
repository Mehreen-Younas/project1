using System.Text.Json;
using System.Text.Json.Serialization;

namespace project1.Models
{
    public class Pasta
    {
        [JsonPropertyName("id")]
        public int pasta_id { get; set; }

        [JsonPropertyName("name")]
        public string pasta_name { get; set; }

        [JsonPropertyName("image")]
        public string pasta_image { get; set; } // book ka model define kr diya or us mai 3 attributes b define kr diyay
        public override string ToString() //by default wo apni marzi ka function apply krny ki bjy mera override wala function apply kry. k koi object create kr k jb function call kry to ye override wala ho.taa k kal ko data store krway to json k formatt mai store ho or phir json ko string or string ko book.cs mai... 
        {
          return JsonSerializer.Serialize<Pasta>(this);
        }

    }
}
