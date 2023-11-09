using System.Runtime.InteropServices;

namespace ErrorReport
{
    public class Report
    {
        public int Id { get; set; }
        public string Rubrik { get; set; } = string.Empty;
        public string Innehåll { get; set; } = string.Empty;
        public string Sammanfattning { get; set; } = string.Empty;
        public string Återskapande { get; set; } = string.Empty;

    }
}
