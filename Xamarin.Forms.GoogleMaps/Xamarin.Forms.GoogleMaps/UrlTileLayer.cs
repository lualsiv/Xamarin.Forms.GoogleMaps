using System;
namespace Xamarin.Forms.GoogleMaps
{
    public class UrlTileLayer : ITileLayer
	{
		private Func<int, int, int, Uri> _makeTileUri;
		public Func<int, int, int, Uri> MakeTileUri 
		{
			get { return _makeTileUri; }
		}

		public object Tag { get; set; }

		public object NativeObject { get; set; }

		public UrlTileLayer(Func<int, int, int, Uri> makeTileUri)
		{
			_makeTileUri = makeTileUri;
		}
	}
}

