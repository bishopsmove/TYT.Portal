using System;

using TYT.Portal.Services;

using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.System;
using Windows.UI.Xaml;

namespace TYT.Portal
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        private Lazy<ActivationService> _activationService;
        private ActivationService ActivationService { get { return _activationService.Value; } }

        bool _isInBackgroundMode = false;

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            InitializeComponent();

            EnteredBackground += App_EnteredBackground;
            LeavingBackground += App_LeavingBackground;

            //Deferred execution until used. Check https://msdn.microsoft.com/library/dd642331(v=vs.110).aspx for further info on Lazy<T> class.
            _activationService = new Lazy<ActivationService>(CreateActivationService);

            MemoryManager.AppMemoryUsageLimitChanging += MemoryManager_AppMemoryUsageLimitChanging;
        }

        private void App_LeavingBackground(object sender, LeavingBackgroundEventArgs e)
        {
            // Mark the transition out of the background state
            _isInBackgroundMode = false;

            // Restore view content if it was previously unloaded
            if (Window.Current.Content == null)
            {
                // CreateRootFrame(ApplicationExecutionState.Running, string.Empty);
                var deferral = e.GetDeferral();
                // TODO: Need restore
                // await Helpers.Singleton<SuspendAndResumeService>.Instance.
                deferral.Complete();
            }
        }

        private void MemoryManager_AppMemoryUsageLimitChanging(object sender, AppMemoryUsageLimitChangingEventArgs e)
        {
            // If app memory usage is over the limit, reduce usage within 2 seconds
            // so that the system does not suspend the app
            if (MemoryManager.AppMemoryUsage >= e.NewLimit)
            {
                ReduceMemoryUsage(e.NewLimit);
            }
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override async void OnLaunched(LaunchActivatedEventArgs e)
        {
            if (!e.PrelaunchActivated)
            {
                await ActivationService.ActivateAsync(e); 
            }
            if(e.PreviousExecutionState == ApplicationExecutionState.Terminated)
            {
                //TODO: Load state from previously suspended application
            }
        }

        /// <summary>
        /// Invoked when the application is activated by some means other than normal launching.
        /// </summary>
        /// <param name="args">Event data for the event.</param>
        protected override async void OnActivated(IActivatedEventArgs args)
        {
            await ActivationService.ActivateAsync(args);
        }
    
        protected override async void OnBackgroundActivated(BackgroundActivatedEventArgs args)
        {
            await ActivationService.ActivateAsync(args);
        }

        private async void App_EnteredBackground(object sender, EnteredBackgroundEventArgs e)
        {
            _isInBackgroundMode = true;

            var deferral = e.GetDeferral();
            await Helpers.Singleton<SuspendAndResumeService>.Instance.SaveStateAsync();
            deferral.Complete();
        }
            
        private ActivationService CreateActivationService()
        {
            return new ActivationService(this, typeof(ViewModels.MainViewModel), new Views.ShellPage());
        }

        /// <summary>
        /// Reduces application memory usage.
        /// </summary>
        /// <remarks>
        /// When the app enters the background, receives a memory limit changing
        /// event, or receives a memory usage increased
        /// event it can optionally unload cached data or even its view content in 
        /// order to reduce memory usage and the chance of being suspended.
        /// 
        /// This must be called from multiple event handlers because an application may already
        /// be in a high memory usage state when entering the background or it
        /// may be in a low memory usage state with no need to unload resources yet
        /// and only enter a higher state later.
        /// </remarks>
        public void ReduceMemoryUsage(ulong limit)
        {
            // If the app has caches or other memory it can free, now is the time.
            // << App can release memory here >>

            // Additionally, if the application is currently
            // in background mode and still has a view with content
            // then the view can be released to save memory and 
            // can be recreated again later when leaving the background.
            if (_isInBackgroundMode && Window.Current.Content != null)
            {
                Helpers.Singleton<ToastNotificationsService>.Instance.ShowToast("Unloading view");

                // Clear the view content. Note that views should rely on
                // events like Page.Unloaded to further release resources. Be careful
                // to also release event handlers in views since references can
                // prevent objects from being collected. C++ developers should take
                // special care to use weak references for event handlers where appropriate.
                Window.Current.Content = null;

                // Finally, clearing the content above and calling GC.Collect() below 
                // is what will trigger each Page.Unloaded handler to be called.
                // In order for the resources each page has allocated to be released,
                // it is necessary that each Page also call GC.Collect() from its
                // Page.Unloaded handler.
            }

            // Run the GC to collect released resources, including triggering
            // each Page.Unloaded handler to run.
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Helpers.Singleton<ToastNotificationsService>.Instance.ShowToast("Finished reducing memory usage");
        }

        
    }
}
