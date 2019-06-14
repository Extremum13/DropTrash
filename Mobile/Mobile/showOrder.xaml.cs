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
		public showOrder ()
		{
			InitializeComponent ();
            Print();
		}

        void Print()
        {
            string ordernum="10";
            string dateOrder = "10.10.10";
            string address = "10";

            numberOfOrder.Text += ordernum;
            dateOfOrder.Text += dateOrder;
            addressOfOrder.Text += address;

            for (int i = 1; i < 5; i++)
            {
                Label label = new Label
                {
                    Text = "Имя " + 15,
                    FontSize = 14
                };
                Stack.Children.Add(label);
            }

            ScrollView scrollView = new ScrollView();
            scrollView.Content = Stack;
            this.Content = scrollView;



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