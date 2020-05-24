using System.Collections.Generic;

namespace CoronaApp.Services.Models
{
    public class PathModel
    {
        public int PatientId { get; set; }
        public List<PathModel> Paths { get; set; }
    }
}