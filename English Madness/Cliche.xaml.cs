using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class Cliche : English_Madness.Common.LayoutAwarePage
    {
        public Cliche()
        {
            this.InitializeComponent();
        }
        int flag = 0;
        DataTransferManager dtm;
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
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }
        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
            dtm.DataRequested -= dtm_DataRequested;
        }
        void dtm_DataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            string textSource = exp1.Text;
            string textTitle = "Cliche Shared From English Madness.";


            DataPackage data = args.Request.Data;
            data.Properties.Title = textTitle;

            data.SetText(textSource);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            dtm = DataTransferManager.GetForCurrentView();
            dtm.DataRequested += dtm_DataRequested;

            if (flag == 0)
            {
                lb1.Items.Clear();
                lb2.Items.Clear();
                XmlReader obj = XmlReader.Create("DataStore/cliche.xml");
                string abc = "", abc2 = "";
                while (obj.Read())
                {
                    try
                    {

                        if (obj.NodeType == XmlNodeType.Element && obj.Name == "Country")
                        {
                            abc2 = obj.ReadInnerXml();
                            if (abc != abc2)
                            {
                                abc = abc2;
                                lb1.Items.Add(abc);
                                lb2.Items.Add(abc);
                            }
                        }
                    }
                    catch
                    {
                        exp.Text = "error";
                        exp1.Text = "error";
                    }
                }
                //obj.Close();
                flag = 1;
            }
        }
        private void lb1_SelectionChanged(object sender, Windows.UI.Xaml.Controls.SelectionChangedEventArgs e)
        {
            // TODO: Add event handler implementation here.           
            String a = lb1.SelectedItem.ToString();


            exp.Text = a;
            s4.Visibility = Visibility.Visible;

        }
        private void lb2_SelectionChanged(object sender, Windows.UI.Xaml.Controls.SelectionChangedEventArgs e)
        {
            // TODO: Add event handler implementation here.           
            String a = lb2.SelectedItem.ToString();
            exp1.Text = a;
            s3.Visibility = Visibility.Visible;



        }
        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>


        private void Grid_SizeChanged_1(object sender, SizeChangedEventArgs e)
        {
            if (ApplicationView.Value == ApplicationViewState.Snapped)
            {
                s1.Visibility = Visibility.Visible;
                s2.Visibility = Visibility.Collapsed;
                lb1.SelectedItem = lb2.SelectedItem;


            }
            else
            {
                s1.Visibility = Visibility.Collapsed;
                s2.Visibility = Visibility.Visible;
                lb2.SelectedItem = lb1.SelectedItem;
                //  exp1 = exp;
            }
        }
    }
}
