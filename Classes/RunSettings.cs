using System.Collections.Generic;

namespace Dart.Classes
{
    public class RunSettings
    {
        public string Filename { get; set; }
        public string ResultDirectory { get; set; }
        public IList<string> DataCollectors { get; set; }
    }
}
