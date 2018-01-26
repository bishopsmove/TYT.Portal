using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYT.Portal.Models
{
    public interface IChannel
    {
        string Title { get; set; }
        string SubTitle { get; set; }
        string Link { get; set; }
        string Description { get; set; }
        string  Category { get; set; }
        string Rating { get; set; }
        string Language { get; set; }
        ObservableCollection<IEpisode> EpisodeList { get; set; }
    }
}
