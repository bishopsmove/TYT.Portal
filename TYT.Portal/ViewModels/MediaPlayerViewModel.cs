using System;
using System.Collections.ObjectModel;

using GalaSoft.MvvmLight;

using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Media.Streaming.Adaptive;

namespace TYT.Portal.ViewModels
{
    public class MediaPlayerViewModel : ViewModelBase
    {
        // TODO WTS: Set your video default and image here
        private const string defaultSource = "https://sec.ch9.ms/ch9/db15/43c9fbed-535e-4013-8a4a-a74cc00adb15/C9L12WinTemplateStudio_high.mp4";
        // The poster image is displayed until the video is started
        private const string defaultPoster = "https://sec.ch9.ms/ch9/db15/43c9fbed-535e-4013-8a4a-a74cc00adb15/C9L12WinTemplateStudio_960.jpg";

        private IMediaPlaybackSource _source;
        public IMediaPlaybackSource Source
        {
            get { return _source; }
            set { Set(ref _source, value); }
        }

        private string _posterSource;
        public string PosterSource
        {
            get { return _posterSource; }
            set { Set(ref _posterSource, value); }
        }

        public MediaPlayerViewModel()
        {
            Source = MediaSource.CreateFromUri(new Uri(defaultSource));
            //var _adaptive = AdaptiveMediaSource.CreateFromUriAsync(new Uri(defaultSource)).
            //Source = MediaSource.CreateFromAdaptiveMediaSource(_adaptive.);
            PosterSource = defaultPoster;
        }
    }
}
