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
        public string pasta_image { get; set; } 
        public override string ToString() 
        {
          return JsonSerializer.Serialize<Pasta>(this);
        }

    }
}
