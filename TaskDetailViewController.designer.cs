// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace assignment1
{
    [Register ("TaskDetailViewController")]
    partial class TaskDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch DoneSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField NotesText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TitleText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DoneSwitch != null) {
                DoneSwitch.Dispose ();
                DoneSwitch = null;
            }

            if (NotesText != null) {
                NotesText.Dispose ();
                NotesText = null;
            }

            if (TitleText != null) {
                TitleText.Dispose ();
                TitleText = null;
            }
        }
    }
}