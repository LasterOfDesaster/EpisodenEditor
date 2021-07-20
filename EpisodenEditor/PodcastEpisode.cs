using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpisodenEditor
{
    public class PodcastEpisode
    {
        public string username { get; set; }
        public Guid guid { get; set; }
        public string title { get; set; }
        public string spotify { get; set; }
        public string amazon { get; set; }
        public string youtube { get; set; }
        public List<string> hosts { get; set; }
        public List<Topic> topics { get; set; }
    }

    public class Topic
    {
        public string name { get; set; }
        public bool community { get; set; }
        public bool ad { get; set; }
        public List<string> subtopics { get; set; }
        public TimeSpan start { get; set; }
        public TimeSpan end { get; set; }
        public override string ToString()
        {
            return this.name;
        }
    }
}
