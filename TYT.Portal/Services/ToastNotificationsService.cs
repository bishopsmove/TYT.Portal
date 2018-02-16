using System.Diagnostics;
using System.Threading.Tasks;

using TYT.Portal.Activation;

using Windows.ApplicationModel.Activation;
using Windows.UI.Notifications;

namespace TYT.Portal.Services
{
    internal partial class ToastNotificationsService : ActivationHandler<ToastNotificationActivatedEventArgs>
    {
        public void ShowToastNotification(ToastNotification toastNotification)
        {
            ToastNotificationManager.CreateToastNotifier().Show(toastNotification);
        }

        /// <summary>
        /// Sends a toast notification
        /// </summary>
        /// <param name="msg">Message to send</param>
        /// <param name="subMsg">Sub message</param>
        public void ShowToast(string msg, string subMsg = null)
        {
            /*
             * TODO: Fix this crap.
            if (subMsg == null)
                subMsg = GetMemoryUsageText();
            */
            Debug.WriteLine(msg + "\n" + subMsg);

            if (!SettingsService.Settings.ToastOnAppEvents)
                return;

            //var toastXml = ToastNotificationsService.GetTemplateContent(ToastTemplateType.ToastText02);

            //var toastTextElements = toastXml.GetElementsByTagName("text");
            //toastTextElements[0].AppendChild(toastXml.CreateTextNode(msg));
            //toastTextElements[1].AppendChild(toastXml.CreateTextNode(subMsg));

            //var toast = new ToastNotification(toastXml);
            //ShowToastNotification(toast);
        }

        protected override async Task HandleInternalAsync(ToastNotificationActivatedEventArgs args)
        {
            // TODO WTS: Handle activation from toast notification,
            // for more info on handling activation see
            // Documentation: https://blogs.msdn.microsoft.com/tiles_and_toasts/2015/07/08/quickstart-sending-a-local-toast-notification-and-handling-activations-from-it-windows-10/

            await Task.CompletedTask;
        }
    }
}
