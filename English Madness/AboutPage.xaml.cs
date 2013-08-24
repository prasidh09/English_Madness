using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.ApplicationSettings;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace English_Madness
{
    public sealed partial class AboutPage : UserControl
    {
        public AboutPage()
        {
            this.InitializeComponent();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Popup parent = this.Parent as Popup;

            if (parent != null)
            {

                parent.IsOpen = false;

            }



            // If the app is not snapped, then the back button shows the Settings pane again.

            if (Windows.UI.ViewManagement.ApplicationView.Value != Windows.UI.ViewManagement.ApplicationViewState.Snapped)
            {

                SettingsPane.Show();

            }
        }

        private async void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            Uri uri = new Uri("http://www.facebook.com/prasidh09");
            await Launcher.LaunchUriAsync(uri);
        }

        private async void TextBlock_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            Uri uri = new Uri("http://www.facebook.com/prasidh09");
            await Launcher.LaunchUriAsync(uri);
        }

        private async void Image_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            Uri uri = new Uri("http://twitter.com/prasidh36");
            await Launcher.LaunchUriAsync(uri);
        }

        private async void TextBlock_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            Uri uri = new Uri("http://twitter.com/prasidh36");
            await Launcher.LaunchUriAsync(uri);
        }

        private async void TextBlock_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            Uri uri = new Uri("mailto:prasidh09@gmail.com");
            await Launcher.LaunchUriAsync(uri);
        }

        private async void Image_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            Uri uri = new Uri("mailto:prasidh09@gmail.com");
            await Launcher.LaunchUriAsync(uri);
        }
    }
}
