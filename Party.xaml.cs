using Microsoft.WindowsAzure.MobileServices;
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
using Newtonsoft.Json;
using System.Threading;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 


    public class PartyLinks
    {
        public string Id { get; set; }
        public string Text { get; set; }
    }
    
    public sealed partial class Party : Page
    {



        public async void fun()
        {

            /*PartyLinks item = new PartyLinks { Text = "https://www.youtube.com/watch?v=t4H_Zoh7G5A&list=PL0D699D8AF0697C63" };
            await App.MobileService.GetTable<PartyLinks>().InsertAsync(item);

            PartyLinks item1 = new PartyLinks { Text = "https://www.youtube.com/watch?v=B7vFWy8NxIU" };
            await App.MobileService.GetTable<PartyLinks>().InsertAsync(item1);


            PartyLinks item2 = new PartyLinks { Text = "https://www.youtube.com/watch?v=eQWG8BVeryU&list=PLB7F569C8942F9537" };
            await App.MobileService.GetTable<PartyLinks>().InsertAsync(item2);


            PartyLinks item3 = new PartyLinks { Text = "https://www.youtube.com/watch?v=YqeW9_5kURI&list=PLw8TejMbmHM6IegrJ4iECWNoFuG7RiCV_" };
            await App.MobileService.GetTable<PartyLinks>().InsertAsync(item3);


            PartyLinks item4 = new PartyLinks { Text = "https://www.youtube.com/watch?v=AihilcnejBA&list=PLA5E12FD861A3B360" };
            await App.MobileService.GetTable<PartyLinks>().InsertAsync(item4);


            PartyLinks item5 = new PartyLinks { Text = "https://www.youtube.com/watch?v=n4RjJKxsamQ&list=PLxXmNu3e7u8L2QwXe_YnIB37hkjjEZkCc" };
            await App.MobileService.GetTable<PartyLinks>().InsertAsync(item5); */

            IMobileServiceTable<PartyLinks> partyTable =
    App.MobileService.GetTable<PartyLinks>();
            List<PartyLinks> list = await partyTable.Where(PartyLinks => PartyLinks.Text != null)
   .ToListAsync();
            Random rnd = new Random();
            int x = rnd.Next(0, list.Count);
            PartyView1.Navigate(new Uri(@list[x].Text));

        }
        public Party()
        {
            this.InitializeComponent();
            // PartyView.Navigate(new Uri(@"https://www.youtube.com/watch?v=y6Sxv-sUYtM"));
            fun();

        }


        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            PartyView1.Navigate(new Uri(@"https://www.google.com"));
            this.Frame.Navigate(typeof(MainPage));
        }
    }
    
}
