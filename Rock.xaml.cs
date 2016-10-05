using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.WindowsAzure.MobileServices;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

public class RockLinks
{
    public string Id { get; set; }
    public string Text { get; set; }
}

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Rock : Page
    {

        public async void Func()
        {

            
            IMobileServiceTable<RockLinks> partyTable =
    App.MobileService.GetTable<RockLinks>();
            List<RockLinks> list = await partyTable.Where(RockLinks => RockLinks.Text != null)
   .ToListAsync();
            Random rnd = new Random();
            int x = rnd.Next(0, list.Count);
            RockView1.Navigate(new Uri(@list[x].Text));

        }

        public Rock()
        {
            this.InitializeComponent();
            Func();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            RockView1.Navigate(new Uri(@"https://www.google.com"));
            this.Frame.Navigate(typeof(MainPage));
        }

        private void WebView_LoadCompleted(object sender, NavigationEventArgs e)
        {

        }
    }
}
