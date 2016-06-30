using System;
namespace Xamarin.Forms.GoogleMaps
{
    public abstract class TileLayer
	{
        public object Tag { get; set; }
        internal object NativeObject { get; set; }
    }
}

