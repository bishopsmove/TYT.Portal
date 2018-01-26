using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYT.Portal.Models
{
    public class Episode : IEpisode
    {

        public string PostId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public string CommentsUrl { get; set; }
        public string ImageUrl { get; set; }
        public IMediaFile MediaLink { get; set; }
        public string Duration { get; set; }
        public string Author { get; set; }
    }
}
