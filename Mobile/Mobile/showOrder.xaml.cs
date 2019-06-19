using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class showOrder : ContentPage
	{
        public Order order=new Order();
        public int id { get; set; }
        Button join = new Button
        {
            Text = "Присойдениться",
            VerticalOptions = LayoutOptions.EndAndExpand,
            HorizontalOptions = LayoutOptions.EndAndExpand           
        };
        Button outOfOrder = new Button
        {
            Text = "Выйти",
            VerticalOptions = LayoutOptions.EndAndExpand,
            HorizontalOptions = LayoutOptions.EndAndExpand
        };

        public showOrder ()
		{
			InitializeComponent ();      
        }
        public showOrder(int ord)
        {
            order = MainPage.AllOrders[ord];
            //order.ordernum = ord.ordernum;
            //order.names = ord.names;
            //order.type = ord.type;
            //order.names = ord.names;
            InitializeComponent();
         
        }

        protected override void OnAppearing()
        {
          
            
            base.OnAppearing();
            Order ord = MainPage.AllOrders[MainPage.selectedOrder];
            Print(MainPage.AllOrders[MainPage.selectedOrder]);
            if (!MainPage.AllOrders[MainPage.selectedOrder].names.Contains(App.mainUser.FIO))
            {

                newStack.Children.Add(join);
                join.Clicked += JoinClicked;
            }
            else
            {
                newStack.Children.Add(outOfOrder);
                outOfOrder.Clicked += outOfOrderCliked;

            }
        }

        void Print()
        {
            string ordernum="10";
            string dateOrder = "10.10.10";
            string address = "10";

            numOfOrder.Text += ordernum;
            dateOfOrder.Text += dateOrder;
            addressOfOrder.Text += address;

            for (int i = 1; i < 5; i++)
            {
                Label label = new Label
                {
                    Text = "Имя " + 15,
                    FontSize = 14
                };
                newStack.Children.Add(label);
            }

            ScrollView scrollView = new ScrollView();
            scrollView.Content = newStack;
            this.Content = scrollView;
        }
        void Print(Order ord)
        {
            int ordernum = ord.ordernum;
            string dateOrder = ord.dateOrder.ToShortDateString();
            string address = ord.address;

            numOfOrder.Text += ordernum;
            dateOfOrder.Text += dateOrder;
            addressOfOrder.Text += address;
            Title = ordernum.ToString();
            for (int i = 1; i < ord.names.Count(); i++)
            {
                Label label = new Label
                {
                    Text = "Имя " + ord.names[i],
                    FontSize = 14
                };
                newStack.Children.Add(label);
            }

            ScrollView scrollView = new ScrollView();
            scrollView.Content = newStack;
            this.Content = scrollView;
        }

        async private void JoinClicked(object sender, EventArgs e)
        {
            MainPage.AllOrders[MainPage.selectedOrder].names.Add(App.mainUser.FIO);
            await Navigation.PopAsync();
            await DisplayAlert("Увеломление", "Вы присойденились к договору", "принять");
        }
        async private void outOfOrderCliked(object sender, EventArgs e)
        {
            MainPage.AllOrders[MainPage.selectedOrder].names.Remove(App.mainUser.FIO);
            await Navigation.PopAsync();
            await DisplayAlert("Увеломление", "Вы покинули договор", "принять");
        }
    }

}
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Xamarin.Forms;
//using Xamarin.Forms.Xaml;


////Супер недоделано



//namespace TrashProj
//{
//	[XamlCompilation(XamlCompilationOptions.Compile)]
//	public partial class OrderPage : ContentPage
//	{
//		public OrderPage(int ordId)
//		{
//			InitializeComponent();

           
//        }

//        void Print(Order order)
//        {
//            StackLayout stackLayout = new StackLayout()
//            {
//                Padding = "15,30,30,30",
//                VerticalOptions = "CenterAndExpand"
                
//            };

            


//                Padding = "15,30,30,30" HorizontalOptions = "CenterAndExpand" VerticalOptions = "CenterAndExpand"


//                           Label x: Name = "numberOfOrder" Text = "Заказ №" HorizontalOptions = "Center" 


//                                 < Label x: Name = "dateOfOrder" Text = "Дата выполнения" HorizontalOptions = "Start" "></Label>
//                                         < Label x: Name = "addressOfOrder" Text = "Адресc " HorizontalOptions = "Start" ></ Label >


//                                           </ StackLayout >


//                                       </ ContentPage.Content >


//                                   </ StackLayout >
//            for (int i = 1; i < order.BuyerList.Size; i++)
//            {
//                Label label = new Label
//                {
//                    Text = "Имя " + BuyerList[i].FIO,
//                    FontSize = 14
//                };
//                stackLayout.Children.Add(label);
//            }

//            ScrollView scrollView = new ScrollView();
//            scrollView.Content = stackLayout;
//            this.Content = scrollView;



//        }
       


//	}
//}