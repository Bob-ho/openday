using Foundation;
using System;
using UIKit;

namespace assignment1
{
    public partial class CourseViewController : UITableViewController
    {
        public CourseViewController (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			string[] image = new string[] { "Art.png", "business.jpg", "Law.jpg", "Health.jpg", "Science.jpg", "Library.jpg", "ielts.jpg", "research.jpg" };
			{
				string[] tableItems = new string[] { "Faculty of Art", "Deakin Business school", "Deakin Law school", "Falculty of Health", "Falculty of Science", "Library", "IELTS Test Centre", "Deakin Research" };
				UITableView table;
				table = new UITableView
				{
					Frame = new CoreGraphics.CGRect(0, 0, View.Bounds.Width, View.Bounds.Height),
					Source = new TableCourse(tableItems, image)
				};
				View.AddSubview(table);

				//table.Source = new TableSource(tableItems);

				//Add(table);
			}

		}
    }
}