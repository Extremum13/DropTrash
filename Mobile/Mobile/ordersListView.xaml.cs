using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ordersListView : ContentPage
    {


        public ordersListView()
        {
            ListView listView = new ListView
            {
                // Source of data items.
                ItemsSource = MainPage.AllOrders,

                // Define template for displaying each item.
                // (Argument of DataTemplate constructor is called for 
                //      each item; it must return a Cell derivative.)
                ItemTemplate = new DataTemplate(() =>
                {
                    // Create views with bindings for displaying each property.
                    Label nameLabel = new Label();
                    nameLabel.SetBinding(Label.TextProperty, "ordernum");

                    Label birthdayLabel = new Label();
                    birthdayLabel.SetBinding(Label.TextProperty,
                        new Binding("dateOrder", BindingMode.OneWay,
                            null, null, "date of order {0:d}"));

                    

                    // Return an assembled ViewCell.
                    var tempCell = new ViewCell
                    {

                        View = new StackLayout
                        {
                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                                {
                                    new StackLayout
                                    {
                                        VerticalOptions = LayoutOptions.Center,
                                        Spacing = 0,
                                        Children =
                                        {
                                            nameLabel,
                                            birthdayLabel
                                        }
                                        }
                                }
                        }
                    };
                    //tempCell.Tapped += TempCell_Tapped;
                    return tempCell;
                })
            };

            listView.ItemTapped += Handle_ItemTapped;
            //listView.ItemSelected += Handle_ItemSelected;

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {                 
                    listView
                }
            };
        }

        //async void TempCell_Tapped(object sender, EventArgs e)
        //{
        //    ViewCell a = sender as Xamarin.Forms.ViewCell;
        //    foreach(var k in listView.ItemsSource)
        //        if(k.Equals(a))
        //            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");




        //    // throw new NotImplementedException();
        //}

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            int i = 0;
            if (e.Item == null)
                return;
            ListView a = sender as Xamarin.Forms.ListView;
            foreach (var k in a.ItemsSource)
            {

                if (a.SelectedItem == k)
                {
                    int f = MainPage.AllOrders[i].ordernum;
                    await Navigation.PushAsync(new showOrder(MainPage.AllOrders[i].ordernum));
                    
                    await DisplayAlert("Item Tapped", "An item was tapped.", "OK");
                }
                i++;
            }
            //IsPresented = false;
            //  if(a.SelectedItem)

            ((ListView)sender).SelectedItem = null;

        }
    }
        
    
}
