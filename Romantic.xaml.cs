using System;
using Microsoft.WindowsAzure.MobileServices;

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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    public class RomanticLinks
    {
        public string Id { get; set; }
        public string Text { get; set; }
    }
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class Romantic : Page
    {
        public async void rom()
        {

              /*RomanticLinks item = new RomanticLinks { Text = "https://www.youtube.com/watch?v=nSRCpertZn8&list=PLkcOr7MC8c9fb6N38SPb7QDaBHadIbbbi" };
  await App.MobileService.GetTable<RomanticLinks>().InsertAsync(item);

  RomanticLinks item1 = new RomanticLinks { Text = "https://www.youtube.com/watch?v=HLphrgQFHUQ&list=PL-zaAzFaYH-tfg-3haP3L1K13njEizwtl" };
  await App.MobileService.GetTable<RomanticLinks>().InsertAsync(item1);


  RomanticLinks item2 = new RomanticLinks { Text = "https://www.youtube.com/watch?v=bRUzf7LgjLM&list=PLQRS4Spr1Ss3awR6v_nj1M5WbKW4s7Oh4" };
  await App.MobileService.GetTable<RomanticLinks>().InsertAsync(item2);


  RomanticLinks item3 = new RomanticLinks { Text = "https://www.youtube.com/watch?v=uL8BM_xJBRA&list=PLPCDrz-Og2T-u0oh_A-O0rwNekXyPWWbr" };
  await App.MobileService.GetTable<RomanticLinks>().InsertAsync(item3);


  RomanticLinks item4 = new RomanticLinks { Text = "https://www.youtube.com/watch?v=MiG5jPmyDFI&list=PLEpfh9jiEpYTbAx1qZRhVUXnl8UHuTHIY" };
  await App.MobileService.GetTable<RomanticLinks>().InsertAsync(item4); 


  RomanticLinks item5 = new RomanticLinks { Text = "https://www.youtube.com/watch?v=Im_ZVNX1QZM&list=PL5omhuWOZfs8yjesccm9bMHQW_s3vNC9R" };
  await App.MobileService.GetTable<RomanticLinks>().InsertAsync(item5); */

            IMobileServiceTable<RomanticLinks> partyTable =
        App.MobileService.GetTable<RomanticLinks>();
            List<RomanticLinks> list = await partyTable.Where(RomanticLinks => RomanticLinks.Text != null)
    .ToListAsync();
            Random rnd = new Random();
            int x = rnd.Next(0, list.Count);
            romanticView.Navigate(new Uri(@list[x].Text)); 
        }
        public Romantic()
        {
            this.InitializeComponent();
            rom();
        }

     

        private void WebView_LoadCompleted(object sender, NavigationEventArgs e)
        {
            
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            romanticView.Navigate(new Uri(@"https://www.google.com"));
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
