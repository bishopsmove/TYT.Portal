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
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SubTitle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Link { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Category { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Rating { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Language { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ObservableCollection<IEpisode> EpisodeList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
