using System;
namespace Xamarin.Forms.GoogleMaps
{
    public class UrlTileLayer : TileLayer
	{
		private Func<int, int, int, Uri> _makeTileUri;
		public Func<int, int, int, Uri> MakeTileUri 
		{
			get { return _makeTileUri; }
		}

		public UrlTileLayer(Func<int, int, int, Uri> makeTileUri)
		{
			_makeTileUri = makeTileUri;
		}
	}
}

