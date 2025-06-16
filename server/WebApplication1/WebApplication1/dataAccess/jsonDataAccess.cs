using System.Text.Json;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.dataAccess
{
    public class jsonDataAccess
    {

            private static readonly string ShiftFile = "Data/shifts.json";
            private static readonly string RequestFile = "Data/requests.json";

            public static List<Shifts> GetShifts()
            {
                string json = File.ReadAllText(ShiftFile);
                return JsonSerializer.Deserialize<List<Shifts>>(json);
            }
        public static void SaveShifts(List<Shifts> shifts)
        {
            string json = JsonSerializer.Serialize(shifts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ShiftFile, json);
        }

        public static bool UpdateShift(Shifts updatedShift)
        {
            var shifts = GetShifts();
            var index = shifts.FindIndex(s => s.Id == updatedShift.Id);
            if (index == -1)
                return false;

            shifts[index] = updatedShift;
            SaveShifts(shifts);
            return true;
        }

        public static List<SwapRequest> GetRequests()
            {
                string json = File.ReadAllText(RequestFile);
                return JsonSerializer.Deserialize<List<SwapRequest>>(json);
            }

            public static void SaveRequests(List<SwapRequest> requests)
            {
                string json = JsonSerializer.Serialize(requests, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(RequestFile, json);
            }

            public static void UpdateRequest(SwapRequest updatedRequest)
            {
                var list = GetRequests();
                var index = list.FindIndex(r => r.Id == updatedRequest.Id);
                if (index != -1)
                {
                    list[index] = updatedRequest;
                    SaveRequests(list);
                }
            }

            public static void AddRequest(SwapRequest newRequest)
            {
                var list = GetRequests();
                newRequest.Id = list.Max(r => r.Id) + 1;
                list.Add(newRequest);
                SaveRequests(list);
            }
        }

    
}
