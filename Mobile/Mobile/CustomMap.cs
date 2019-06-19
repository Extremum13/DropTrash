using System;
using System.Collections.Generic;
using Xamarin.Forms.Maps;
namespace Mobile
{
    public class CustomMap : Map
    {
        //public event EventHandler<MapTapEventArgs> Tapped;
        public List<CustomPin> CustomPins { get; set; }
        //public bool addTarget { get; set; }
        //public Position position { get; set; }
       

        //public void OnTap(Position coordinate)
        //{

        //    //OnTap(new MapTapEventArgs { Position = coordinate });
        //    if (coordinate != null)
        //    position = coordinate;
        //}

        //protected virtual void OnTap(MapTapEventArgs e)
        //{
        //    var handler = Tapped;

        //    if (handler != null)
        //        handler(this, e);
        //}
    }
    //public class MapTapEventArgs : EventArgs
    //{
    //    public Position Position { get; set; }
    //}
}
