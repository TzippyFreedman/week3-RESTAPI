using System;
using System.Collections.Generic;

namespace CoronaApp.Services.Models
{
    public class Path
    {
        public int Id { get; set; }
        public string City { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
    }
}