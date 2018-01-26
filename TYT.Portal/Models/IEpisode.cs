using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYT.Portal.Models
{
    public interface IEpisode
    {
        string PostId { get; set; }
        string Title { get; set; }
        string SubTitle { get; set; }
        string Summary { get; set; }
        string Description { get; set; }
        DateTime PublishDate { get; set; }
        string CommentsUrl { get; set; }
        string ImageUrl { get; set; }
        IMediaFile MediaLink { get; set; }
        string Duration { get; set; }
        string Author { get; set; }


    }
}
