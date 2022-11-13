// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace triangles
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField aLabel { get; set; }

		[Outlet]
		AppKit.NSTextField aTextField { get; set; }

		[Outlet]
		AppKit.NSTextField bLabel { get; set; }

		[Outlet]
		AppKit.NSTextField bTextField { get; set; }

		[Outlet]
		AppKit.NSTextField cLabel { get; set; }

		[Outlet]
		AppKit.NSTextField cTextField { get; set; }

		[Outlet]
		AppKit.NSTextField outputAngles { get; set; }

		[Outlet]
		AppKit.NSTextField outputLabel { get; set; }

		[Action ("checkVals:")]
		partial void checkVals (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (aLabel != null) {
				aLabel.Dispose ();
				aLabel = null;
			}

			if (bLabel != null) {
				bLabel.Dispose ();
				bLabel = null;
			}

			if (cLabel != null) {
				cLabel.Dispose ();
				cLabel = null;
			}

			if (aTextField != null) {
				aTextField.Dispose ();
				aTextField = null;
			}

			if (bTextField != null) {
				bTextField.Dispose ();
				bTextField = null;
			}

			if (cTextField != null) {
				cTextField.Dispose ();
				cTextField = null;
			}

			if (outputLabel != null) {
				outputLabel.Dispose ();
				outputLabel = null;
			}

			if (outputAngles != null) {
				outputAngles.Dispose ();
				outputAngles = null;
			}
		}
	}
}
