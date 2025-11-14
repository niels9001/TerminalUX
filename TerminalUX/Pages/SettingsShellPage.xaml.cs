using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.ApplicationSettings;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TerminalUX.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsShellPage : Page
    {
        public SettingsShellPage()
        {
            InitializeComponent();
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            Navigate(args.InvokedItemContainer.Tag.ToString()!);
        }


        public void Navigate(string Tag)
        {
            Tag = Tag.ToLower(CultureInfo.CurrentCulture);

            switch (Tag)
            {
                case "profile":
                    NavFrame.Navigate(typeof(DefaultsPage));
                    break;
                case "startup":
                    NavFrame.Navigate(typeof(StartupPage));
                    break;
                default:
                    NavFrame.Navigate(typeof(DefaultsPage));
                    break;
            }
        }

        private void NavigationView_Loaded(object sender, RoutedEventArgs e)
        {
            NavView.SelectedItem = NavView.MenuItems[0];
            NavFrame.Navigate(typeof(StartupPage));
        }
    }
}
