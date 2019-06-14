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
      

        public MainPage()
        {
            IsPresented = true;

            InitializeComponent();



        }


        private void AddPinsToMap(List<Pin> pins)
        {
            for (int i = 0; i < pins.Count(); i++)
            {
                if (!tMap.Pins.Contains(pins[i]))
                {
                    tMap.Pins.Add(pins[i]);
                    pins[i].Clicked += Pin_Clicked;
                }
            }
        }

        private List<Pin> CreatePin(List<int> orders)
        {
            List<Pin> pins = new List<Pin>();
            for (float i = 0;i<orders.Count();i++) {

                    Pin temppin = new Pin()                         
                {
                    Label = "Content "+ i,
                    Position = new Position(50, 36.14+i/100)
                };
                pins.Add(temppin);

            }
            return pins;

        }

        private async void Pin_Clicked(object sender, EventArgs e)
        {
            var temp = sender as Pin;
            await DisplayAlert("Title", temp.Label, "can");
            await Navigation.PushAsync(new showOrder());
            IsPresented = false;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            List<int> tempArr = new List<int> { 5, 3, 2, 1, 4 };



            tMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(50, 36.15), Distance.FromKilometers(15)));
            // CreatePin();
            List<Pin> pins  = CreatePin(tempArr);
            

            Pin pin1 = new Pin()
            {
                Label = "Content111",
                Position = new Position(50, 36.14)
            };
            Pin pin2 = new Pin()
            {
                Label = "Content222",
                Position = new Position(50, 36.17)
            };
            Pin pin3 = new Pin()
            {
                Label = "Content333",
                Position = new Position(50, 36.19)
            };

            pins.Add(pin1);
            pins.Add(pin2);
            pins.Add(pin3);

            //tMap.Pins.Add(pin1);
            //tMap.Pins.Add(pin2);
            //tMap.Pins.Add(pin3);

            //pins[0].Clicked += Pin_Clicked;
            //pins[1].Clicked += Pin_Clicked;
            //pins[2].Clicked += Pin_Clicked;


            AddPinsToMap(pins);
        }

        
        private  void Orders_Clicked(object sender, EventArgs e)
        {

            IsPresented = false;
        }

        private void Chat_Clicked(object sender, EventArgs e)
        {
            IsPresented = false;

        }
       
    }
}