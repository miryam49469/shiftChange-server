using System.Text.Json.Serialization;

namespace WebApplication1.Models
{
    public class SwapRequest
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("shift_type")]
        public string ShiftType { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("shift_id")]
        public int ShiftId { get; set; }

        [JsonPropertyName("employee_name")]
        public string EmployeeName { get; set; }

        [JsonPropertyName("requested_to")]
        public string RequestedTo { get; set; }
    }
}
