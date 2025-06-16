using System.Text.Json.Serialization;

namespace WebApplication1.Models
{
    public class Shifts
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("employee_name")]
        public string Employee_name { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("shiftType")]
        public string ShiftType { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
