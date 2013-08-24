using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace English_Madness
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class StartPage : English_Madness.Common.LayoutAwarePage
    {
       

        
        public StartPage()
        {
            this.InitializeComponent();
            tileup();

            
        }
        void tileup()
        {
            TileUpdateManager.
                CreateTileUpdaterForApplication().
                EnableNotificationQueue(true);

            XmlDocument tileXml = TileUpdateManager.
            GetTemplateContent
            (TileTemplateType.TileWideText01);
            XmlElement textElement = (XmlElement)tileXml.
            GetElementsByTagName("text")[0];
            textElement.AppendChild(
            tileXml.CreateTextNode
            ("Anagrams"));

            TileUpdateManager.CreateTileUpdaterForApplication()
            .Update(new TileNotification(tileXml));

            XmlDocument tileXml1 = TileUpdateManager.
            GetTemplateContent
            (TileTemplateType.TileWideText01);

            XmlElement textElement1 = (XmlElement)tileXml1.
            GetElementsByTagName("text")[0];
            textElement1.AppendChild(
            tileXml1.CreateTextNode
            ("Cliche"));

            TileUpdateManager.CreateTileUpdaterForApplication()
            .Update(new TileNotification(tileXml1));

            XmlDocument tileXml2 = TileUpdateManager.
            GetTemplateContent
            (TileTemplateType.TileWideText01);

            XmlElement textElement2 = (XmlElement)tileXml2.
            GetElementsByTagName("text")[0];
            textElement2.AppendChild(
            tileXml2.CreateTextNode
            ("Gre Preparation"));

            TileUpdateManager.CreateTileUpdaterForApplication()
            .Update(new TileNotification(tileXml2));

            XmlDocument tileXml3 = TileUpdateManager.
            GetTemplateContent
            (TileTemplateType.TileWideText01);

            XmlElement textElement3 = (XmlElement)tileXml3.
            GetElementsByTagName("text")[0];
            textElement3.AppendChild(
            tileXml3.CreateTextNode
            ("Metaphor"));

            TileUpdateManager.CreateTileUpdaterForApplication()
            .Update(new TileNotification(tileXml3));

            XmlDocument tileXml4 = TileUpdateManager.
            GetTemplateContent
            (TileTemplateType.TileWideText01);

            XmlElement textElement4 = (XmlElement)tileXml4.
            GetElementsByTagName("text")[0];
            textElement4.AppendChild(
            tileXml4.CreateTextNode
            ("Palindrome"));

            TileUpdateManager.CreateTileUpdaterForApplication()
            .Update(new TileNotification(tileXml4));

            XmlDocument tileXml5 = TileUpdateManager.
            GetTemplateContent
            (TileTemplateType.TileWideText01);

            XmlElement textElement5 = (XmlElement)tileXml5.
            GetElementsByTagName("text")[0];
            textElement5.AppendChild(
            tileXml5.CreateTextNode
            ("Pleonasm"));

            TileUpdateManager.CreateTileUpdaterForApplication()
            .Update(new TileNotification(tileXml5));

            XmlDocument tileXml6 = TileUpdateManager.
            GetTemplateContent
            (TileTemplateType.TileWideText01);

            XmlElement textElement6 = (XmlElement)tileXml6.
            GetElementsByTagName("text")[0];
            textElement6.AppendChild(
            tileXml6.CreateTextNode
            ("Quotes"));

            TileUpdateManager.CreateTileUpdaterForApplication()
            .Update(new TileNotification(tileXml6));

        }
        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            tileup();
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
            tileup();
        }

        private void Grid_SizeChanged_1(object sender, SizeChangedEventArgs e)
        {
            if (ApplicationView.Value == ApplicationViewState.Snapped)
            {
                backButton.Visibility = Visibility.Collapsed;
                anagram.Height = anagram.Width = cliche.Width = cliche.Height = gre.Width = gre.Height = metaphor.Width = metaphor.Height = palindrome.Height = palindrome.Width = pleonasm.Width = pleonasm.Height = quotes.Width = quotes.Height = 200;

            }
            else
            {
                backButton.Visibility = Visibility.Visible;
                anagram.Height = anagram.Width = cliche.Width = cliche.Height = gre.Width = gre.Height = metaphor.Width = metaphor.Height = palindrome.Height = palindrome.Width = pleonasm.Width = pleonasm.Height = quotes.Width = quotes.Height = 300;
            }
        }

        private void anagram_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Anagrams));
        }

        private void cliche_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Cliche));
        }

        private void gre_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GRE));
        }

        private void metaphor_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Metaphor));
        }

        private void palindrome_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Palindrome));
        }

        private void pleonasm_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pleonasm));
        }

        private void quotes_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Quotes));
        }


    }
}
