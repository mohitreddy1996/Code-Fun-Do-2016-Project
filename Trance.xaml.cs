using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.WindowsAzure.MobileServices;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public class TranceLinks
    {
        public string Id { get; set; }
        public string Text { get; set; }
    }

    public sealed partial class Trance : Page
    {

        public async void func2()
        {

            

            IMobileServiceTable<TranceLinks> partyTable =
    App.MobileService.GetTable<TranceLinks>();
            List<TranceLinks> list = await partyTable.Where(TranceLinks => TranceLinks.Text != null)
   .ToListAsync();
            Random rnd = new Random();
            int x = rnd.Next(0, list.Count);
            TranceView1.Navigate(new Uri(@list[x].Text));

        }

        public Trance()
        {
            this.InitializeComponent();
            func2();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            TranceView1.Navigate(new Uri(@"https://www.google.com"));
            this.Frame.Navigate(typeof(MainPage));
        }

        private void WebView_LoadCompleted(object sender, NavigationEventArgs e)
        {

        }
    }
}
