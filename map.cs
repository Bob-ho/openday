using System;
using MapKit;
using UIKit;
using CoreGraphics;

namespace assignment1
{
	class MapDelegate : MKMapViewDelegate
	{
		static string annotationId = "ConferenceAnnotation";
		UIImageView venueView;
		UIImage venueImage;

		public override MKAnnotationView GetViewForAnnotation(MKMapView mapView, IMKAnnotation annotation)
		{
			MKAnnotationView annotationView = null;

			if (annotation is MKUserLocation)
				return null;

			if (annotation is ConferenceAnnotation)
			{

				// show conference annotation
				annotationView = mapView.DequeueReusableAnnotation(annotationId);

				if (annotationView == null)
					annotationView = new MKAnnotationView(annotation, annotationId);

				annotationView.Image = UIImage.FromFile("conference.png");
				annotationView.CanShowCallout = true;
			}

			return annotationView;
		}

		public override void DidSelectAnnotationView(MKMapView mapView, MKAnnotationView view)
		{
			// show an image view when the conference annotation view is selected
			if (view.Annotation is ConferenceAnnotation)
			{

				venueView = new UIImageView();
				venueView.ContentMode = UIViewContentMode.ScaleAspectFit;
				venueImage = UIImage.FromFile("venue.png");
				venueView.Image = venueImage;
				view.AddSubview(venueView);

				UIView.Animate(0.4, () =>
				{
					venueView.Frame = new CGRect(-75, -75, 200, 200);
				});
			}
		}

		public override void DidDeselectAnnotationView(MKMapView mapView, MKAnnotationView view)
		{
			// remove the image view when the conference annotation is deselected
			if (view.Annotation is ConferenceAnnotation)
			{

				venueView.RemoveFromSuperview();
				venueView.Dispose();
				venueView = null;
			}
		}

		public override MKOverlayView GetViewForOverlay(MKMapView mapView, IMKOverlay overlay)
		{
			var circleOverlay = overlay as MKCircle;
			var circleView = new MKCircleView(circleOverlay);
			circleView.FillColor = UIColor.Green;
			return circleView;
		}
	}
}
