using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace Mobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public static List<Order> AllOrders = new ListOfOrder().orders;
        public static int selectedOrder;
        public static User user;
        public MainPage()
        {
            IsPresented = true;

            
            InitializeComponent();


        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var ter = new ListOfOrder().orders;
            List<int> tempArr = new List<int> { 5, 3, 2, 1, 4 };
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(50, 36.15), Distance.FromKilometers(15)));
            // CreatePin();
            List<CustomPin> pins = CreateCustomPin(AllOrders);
            AddPinsToMap(pins);

        }

        private void AddPinsToMap(List<CustomPin> pins)
        {
            for (int i = 0; i < pins.Count(); i++)
            {
                if (!customMap.Pins.Contains(pins[i]))
                {
                    customMap.Pins.Add(pins[i]);
                    pins[i].Clicked += CustomPin_Cliked;
                }
            }
        }

        private List<CustomPin> CreateCustomPin(List<int> orders)
        {
            List<CustomPin> pins = new List<CustomPin>();
            for (float i = 0;i<orders.Count();i++) {

                    CustomPin temppin = new CustomPin()
                    {
                        Type = PinType.Place,
                        Position = new Position(50, 36.14 + i / 100),
                        Label =  "Номер заказа: "+i+ " Состояние: "+ Convert.ToString(i),

                        Address = "394 Pacific Ave, San Francisco CA",
                        Id = "Xamarin",

                };
                pins.Add(temppin);
               // temppin.Label = "KULLLL";

            }
            return pins;

        }
        private List<CustomPin> CreateCustomPin(List<Order> orders)
        {
            List<CustomPin> pins = new List<CustomPin>();
            for (int i = 0; i < orders.Count(); i++)
            {

                string[] str = orders[i].coord.Split(' ');

                double X = Double.Parse(str[0]);
                double y = Double.Parse(str[1]);

                var Position = new Position(Convert.ToDouble(str[0]), Convert.ToDouble(str[1]));

                CustomPin temppin = new CustomPin()
                {
                    Type = PinType.Place,
                    Position = new Position(Double.Parse(str[0]), Double.Parse(str[1])),
                    Label = "Номер заказа: " + orders[i].ordernum + " Состояние: " + Convert.ToString(orders[i].type),
                    order = orders[i],
                    Address = orders[i].address,
                    Id = "Xamarin",
                };
                pins.Add(temppin);
                // temppin.Label = "KULLLL";

            }
            return pins;

        }





        private async void CustomPin_Cliked(object sender, System.EventArgs e)
        {
            var temp = sender as CustomPin;
            int i = 0;

            //string[] tempNum = temp.Label.Split(' ');
            //Order ord = AllOrders.Find(order=> order.ordernum==Convert.ToInt32(tempNum[2]));
            //await DisplayAlert("АУ", "ААА", "Ау");
            foreach (var k in AllOrders)
            {
                
                if (k.ordernum.Equals(temp.order.ordernum))
                {
                    selectedOrder = i;
                    await Navigation.PushAsync(new showOrder() { id = temp.order.ordernum });
                    break;
                }
                i++;
            }
            IsPresented = false;
            temp = null;
            sender = null;
            i = 0;
        }
        private  void Orders_Clicked(object sender, EventArgs e)
        {

            IsPresented = false;
        }

        private void Chat_Clicked(object sender, EventArgs e)
        {
            IsPresented = false;

        }

        





        //private async void Pin_Clicked(object sender, EventArgs e)
        //{
        //    var temp = sender as Pin;
        //    await DisplayAlert("Title", temp.Label, "can");

        //    await Navigation.PushAsync(new showOrder());
        //    IsPresented = false;

        //}

    }
}