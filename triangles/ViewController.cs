using System;

using AppKit;
using Foundation;
using GameController;

namespace triangles
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

        public void Analize(int a, int b, int c)
        {
            // Check for invalid side lengths
            if ((a + b) <= c || (b + c) <= a || (c + a) <= b)
            {
                outputLabel.StringValue = "These side lengths produce an invalid triangle";
                outputAngles.StringValue = "";
                return;
            }
            String sideType = "";
            String angleType = "";

            // Equilateral - Check if all sides are equal
            if ((a == b) && (b == c))
            {
                sideType = "equilateral";
            }
            // Isosceles     Check if two sides are the same
            else if ((a == b) || (b == c) || (c == a))
            {
                sideType = "isosceles";
            }
            // No sides are equal
            else
            {
                sideType = "scalene";
            }

            // Right triangle
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                angleType = "right";
            }
            // Acute Triangle
            else if (Math.Pow(a, 2) + Math.Pow(b, 2) > Math.Pow(c, 2))
            {
                angleType = "acute";
            }
            // Obtuse Triangle
            else
            {
                angleType = "obtuse";
            }

            outputLabel.StringValue = "These side lengths produce a valid " + angleType + " triangle";

            // EC portion
            // If it is an equilateral triangle, then all degrees are equal with 60
            if (sideType == "equilateral")
            {
                outputAngles.StringValue = "Angle A = 60.00\nAngle B = 60.00\nAngle C = 60.00";
            }
            else
            {
                double radA = Math.Acos(Convert.ToDouble((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c)));
                double degreesA = (180 / Math.PI) * radA;
                double radB = Math.Acos(Convert.ToDouble((Math.Pow(c, 2) + Math.Pow(a, 2) - Math.Pow(b, 2)) / (2 * c * a)));
                double degreesB = (180 / Math.PI) * radB;
                double radC = Math.Acos(Convert.ToDouble((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b)));
                double degreesC = (180 / Math.PI) * radC;
                outputAngles.StringValue = "Angle A = " + degreesA.ToString("#.##") + "\nAngle B = " + degreesB.ToString("#.##") + "\nAngle C = " + degreesC.ToString("#.##");

            }
            return;
        }

        partial void checkVals(NSObject sender)
        {
			int a;
			int b;
			int c;

			String aInput = aTextField.StringValue;
            bool parseSuccessA = int.TryParse(aInput, out a);
            String bInput = bTextField.StringValue;
            bool parseSuccessB = int.TryParse(bInput, out b);
            String cInput = cTextField.StringValue;
            bool parseSuccessC = int.TryParse(cInput, out c);

            if (!parseSuccessA || !parseSuccessB || !parseSuccessC || a < 0 || b < 0 || c < 0)
            {
				outputLabel.StringValue = "Invalid input(s), must be a positive integer";
                return;
            }
            Analize(a, b, c);
        }
    }
}
