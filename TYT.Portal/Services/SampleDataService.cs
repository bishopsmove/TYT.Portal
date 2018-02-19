using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading.Tasks;

using TYT.Portal.Models;

namespace TYT.Portal.Services
{
    // This class holds sample data used by some generated pages to show how they can be used.
    // TODO WTS: Delete this file once your app is using real data.
    public static class SampleDataService
    {
        private static IEnumerable<IEpisode> AllEpisodes()
        {
            // The following is order summary data
            var data = new ObservableCollection<IEpisode>
            {
                new Episode
                {
                    PostId = "466185",
                    Title = "TYT Hour 1 October 10, 2016",
                    SubTitle = "",
                    PublishDate = DateTime.ParseExact("Mon, 10 Oct 2016 18:13:09 GMT", "r", new CultureInfo("en-US")),
                    Description = "Presidential polls updates. Tiffany Trump awkwardly ducks a kiss from Trump. More leaked Clinton emails. House Speaker Paul Ryan not campaigning with Trump. Donald Trump’s campaign manager Kellyanne Conway defends Trump. Alabama Sen. Jeff Sessions thinks grabbing women’s genitals not sexual assault.",
                    Duration = "57:02",
                    ImageUrl = "http://tyt20160412.wpengine.com/wp-content/uploads/powerpress/TheYoungTurks_1440x1440-320.png"
                },
                new Episode
                {
                    PostId = "466188",
                    Title = "TYT Hour 2 October 10, 2016",
                    SubTitle="",
                    PublishDate = DateTime.ParseExact("Mon, 10 Oct 2016 18:15:25 GMT", "r", new CultureInfo("en-US")),
                    Description = "Body language expert on Trump lurking. New internet sensation: Mr. Bone. Billy Bush suspended from Today Show. Tesla CEO on breaking world out of “The Matrix.” Rapist claims penis too small to rape.",
                    Duration = "43:37",
                    ImageUrl = "http://tyt20160412.wpengine.com/wp-content/uploads/powerpress/TheYoungTurks_1440x1440-320.png"
                },
                new Episode
                {
                    PostId = "466190",
                    Title = "Post Game: October 10, 2016",
                    SubTitle = "",
                    PublishDate = DateTime.ParseExact("Mon, 10 Oct 2016 18:17:06 GMT", "r", new CultureInfo("en-US")),
                    Description = "Cenk, Brett, and Grace debate “trigger warnings” and oversensitive people. Grace shares her feelings on the term “dyke,” while Cenk discusses his thoughts on race-driven comedians. The conversations shifts to Brett’s painful sting ray sting.",
                    Duration = "27:56",
                    ImageUrl = "http://tyt20160412.wpengine.com/wp-content/uploads/powerpress/TheYoungTurks_1440x1440-320.png"
                },
                new Episode
                {
                    PostId = "466164",
                    Title = "TYT Hour 1 October 7, 2016",
                    SubTitle = "",
                    PublishDate = DateTime.ParseExact("Fri, 07 Oct 2016 19:24:58 GMT", "r", new CultureInfo("en-US")),
                    Description = "Cenk, John Iadarola, Michael Shure, and Alonzo Bodden for Friday’s Power Panel. Hurricane Matthew’s trail of destruction in Haiti. Rush Limbaugh says liberal conspiracy. Trump’s vulgarity. Trump on “Central Park Five.”",
                    Duration = "50:20",
                    ImageUrl = "http://tyt20160412.wpengine.com/wp-content/uploads/powerpress/TheYoungTurks_1440x1440-320.png"
                },
                new Episode
                {
                    PostId = "466167",
                    Title = "TYT Hour 2 October 7, 2016",
                    SubTitle = "",
                    PublishDate = DateTime.ParseExact("Fri, 07 Oct 2016 19:26:23 GMT", "r", new CultureInfo("en-US")),
                    Description = "Cenk, Brett Erlich, Alonzo Bodden, and Amberia Allen hosting Friday’s Power Panel. Shepard Smith’s bizarre coverage of Hurricane Matthew. Football coach fired after punishing bully. ‘Sexy burka’ banned on Amazon. Extreme vegan mother malnourishes child. Statistics on open relationships and cheating.",
                    Duration = "47:37",
                    ImageUrl = "http://tyt20160412.wpengine.com/wp-content/uploads/powerpress/TheYoungTurks_1440x1440-320.png"
                },
                new Episode
                {
                    PostId = "466169",
                    Title = "Post Game: October 7, 2016",
                    SubTitle = "",
                    PublishDate = DateTime.ParseExact("Fri, 07 Oct 2016 19:27:52 GMT", "r", new CultureInfo("en-US")),
                    Description = "Malcolm tells the story of meeting Sir Mix-A-Lot. Updates on Gaza and the Niger Delta Avengers. Oliver North’s 73rd birthday celebration. Weekly Whirled News segment on Sweden’s economic boom due to refugees, grandmothers of the plaza de mayo in Argentina, dwarf crocodiles found in Abanda caves of Gabon. Malcolm introduces a new game: Pokémon Go Character or Famous DJ? TTOTB ...",
                    Duration = "1:00:57",
                    ImageUrl = "http://tyt20160412.wpengine.com/wp-content/uploads/powerpress/TheYoungTurks_1440x1440-320.png"
                },
                new Episode
                {
                    PostId = "466136",
                    Title = "TYT Hour 1 October 6, 2016",
                    SubTitle = "",
                    PublishDate = DateTime.ParseExact("Thu, 06 Oct 2016 18:24:09 GMT", "r", new CultureInfo("en-US")),
                    Description = "Ted Cruz working phones for Trump. Gary Johnson can’t name North Korean dictator. Megyn Kelly throws shade at Hanity. Trump takes credit for Pence’s debate performance. Trump’s tax accountant takes credit for lowering his tax bill. Officers smash man’s head into car windscreen.",
                    Duration = "50:20",
                    ImageUrl = "http://tyt20160412.wpengine.com/wp-content/uploads/powerpress/TheYoungTurks_1440x1440-320.png"
                },
                new Episode
                {
                    PostId = "466139",
                    Title = "TYT Hour 2 October 6, 2016",
                    SubTitle = "",
                    PublishDate = DateTime.ParseExact("Thu, 06 Oct 2016 18:26:14 GMT", "r", new CultureInfo("en-US")),
                    Description = "Bees endangered. Champion chess player boycotts championship in Iran over hijab ban. Teen arrested over milk carton. Meteorologist blames deforestation in Haiti on children eating trees. Authorities banning clown costumes. Joseph Buck’s hair loss.",
                    Duration = "47:37",
                    ImageUrl = "http://tyt20160412.wpengine.com/wp-content/uploads/powerpress/TheYoungTurks_1440x1440-320.png"
                },
                new Episode
                {
                    PostId = "466141",
                    Title = "Post Game: October 6, 2016",
                    SubTitle = "",
                    PublishDate = DateTime.ParseExact("Thu, 06 Oct 2016 18:27:41 GMT", "r", new CultureInfo("en-US")),
                    Description = "Cenk and Ana debate over whether or not ignorance is bliss. Both share real life experiences that have shaped their perspectives.",
                    Duration = "18:08",
                    ImageUrl = "http://tyt20160412.wpengine.com/wp-content/uploads/powerpress/TheYoungTurks_1440x1440-320.png"
                },
            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<IEpisode>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllEpisodes();
        }
    }
}
