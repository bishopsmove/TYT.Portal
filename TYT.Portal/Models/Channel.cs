using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYT.Portal.Models
{
    public class Channel : IChannel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Rating { get; set; }
        public string Language { get; set; }
        public ObservableCollection<IEpisode> EpisodeList { get; set; }
    }
}
