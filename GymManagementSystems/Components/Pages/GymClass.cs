using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystems.Components.Pages
{
    // Class to represent a gym class
    public class GymClass
    {
        public string Name { get; set; } = string.Empty;
        public string Instructor { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
    }
}
