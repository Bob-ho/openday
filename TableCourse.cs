using System;
using Foundation;
using UIKit;

namespace assignment1
{
	public class TableCourse: UITableViewSource
	{
		string[] tableItems;
		string[] image;
		String cellIdentifier = "TableCell";
		public TableCourse(string[] items,string[] img)
		{
			tableItems = items;
			image = img;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
			if (cell == null)
			{
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
			}
			cell.TextLabel.Text = tableItems[indexPath.Row];
			cell.ImageView.Image = UIImage.FromFile(image[indexPath.Row]);
			return cell;
			
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return tableItems.Length;
		}
	}
}

