using System;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;

namespace AiXiFan.Uwp.Extensions
{
    public static class ButtonExtensions
    {
        public static void PerformClick(this Button button)
        {
            if (button == null)
            {
                throw new ArgumentNullException(nameof(button));
            }

            var automationPeer = FrameworkElementAutomationPeer.CreatePeerForElement(button);
            var invokeProvider = automationPeer?.GetPattern(PatternInterface.Invoke) as IInvokeProvider;
            invokeProvider?.Invoke();
        }
    }
}