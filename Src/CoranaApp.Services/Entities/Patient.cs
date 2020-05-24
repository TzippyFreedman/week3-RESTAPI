using System.Collections.Generic;

namespace CoronaApp.Services.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Moniker { get; set; }
        public List<Path> Paths { get; set; }
    }
}