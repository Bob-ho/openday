using Foundation;
using System;
using UIKit;
using MapKit;
using CoreGraphics;
using CoreLocation;
namespace assignment1
{
    public partial class MapViewController : UIViewController
    {
		MKMapView map;
		MapDelegate mapDelegate;

		public MapViewController (IntPtr handle) : base (handle)
        {
        }
		//MKMapView map;
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			map = new MKMapView(UIScreen.MainScreen.Bounds);
			map.MapType = MKMapType.Standard;
			map.ZoomEnabled = true;
			map.ScrollEnabled = true;
			double lat = -37.846982;
			double lon = 145.115160;
			CLLocationCoordinate2D mapCenter = new CLLocationCoordinate2D(lat, lon);
			MKCoordinateRegion mapRegion = MKCoordinateRegion.FromDistance(mapCenter, 300, 300);
			map.CenterCoordinate = mapCenter;
			map.Region = mapRegion;
			// set the map delegate
			mapDelegate = new MapDelegate();
			map.Delegate = mapDelegate;

			// add a custom annotation at the map center
			map.AddAnnotations(new ConferenceAnnotation("Evolve Conference", mapCenter));

			var circleOverlay = MKCircle.Circle(mapCenter, 100);
			map.AddOverlay(circleOverlay);

			UITapGestureRecognizer tap = new UITapGestureRecognizer(g =>
			{
				var pt = g.LocationInView(map);
				CLLocationCoordinate2D tapCoord = map.ConvertPoint(pt, map);

				Console.WriteLine("new CLLocationCoordinate2D({0}, {1}),", tapCoord.Latitude, tapCoord.Longitude);
			});

			map.AddGestureRecognizer(tap);
			View = map;
		}

    }
}