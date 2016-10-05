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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public class MotivationalLinks
    {
        public string Id { get; set; }
        public string Text { get; set; }
    }

    

    public sealed partial class Motivate : Page
    {


        public async void fun()
        {

          /*  MotivationalLinks item = new MotivationalLinks { Text = "https://www.youtube.com/watch?v=OSEw6kv70Xw&list=PLPgxpDYmH7dRpjlj9mSXPTls7Y3XdsLyR" };
            await App.MobileService.GetTable<MotivationalLinks>().InsertAsync(item);

            MotivationalLinks item1 = new MotivationalLinks { Text = "https://www.youtube.com/watch?v=mk48xRzuNvA&list=PLkBnz4liFlLLSa3fj01dLF0OfWwEBqsU4" };
            await App.MobileService.GetTable<MotivationalLinks>().InsertAsync(item1);


            MotivationalLinks item2 = new MotivationalLinks { Text = "https://www.youtube.com/watch?v=8DMF0U6xV78" };
            await App.MobileService.GetTable<MotivationalLinks>().InsertAsync(item2);


            MotivationalLinks item3 = new MotivationalLinks { Text = "https://www.youtube.com/watch?v=hT_nvWreIhg&list=PLhGO2bt0EkwvRUioaJMLxrMNhU44lRWg8" };
            await App.MobileService.GetTable<MotivationalLinks>().InsertAsync(item3);


            MotivationalLinks item4 = new MotivationalLinks { Text = "https://www.youtube.com/watch?v=Xn676-fLq7I&list=PLR2s-2Fdtf537fwHVFeX93Xb7nswKvkT5" };
            await App.MobileService.GetTable<MotivationalLinks>().InsertAsync(item4); 


            MotivationalLinks item5 = new MotivationalLinks { Text = "https://www.youtube.com/watch?v=MR6FXpaECY8" };
            await App.MobileService.GetTable<MotivationalLinks>().InsertAsync(item5); */

            IMobileServiceTable<MotivationalLinks> partyTable =
        App.MobileService.GetTable<MotivationalLinks>();
            List<MotivationalLinks> list = await partyTable.Where(MotivationalLinks => MotivationalLinks.Text != null)
    .ToListAsync();
            Random rnd = new Random();
            int x = rnd.Next(0, list.Count);
            motivationalView.Navigate(new Uri(@list[x].Text)); 

        }

        public Motivate()
        {
            this.InitializeComponent();
            fun();
        }

        

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            motivationalView.Navigate(new Uri(@"https://www.google.com"));
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
