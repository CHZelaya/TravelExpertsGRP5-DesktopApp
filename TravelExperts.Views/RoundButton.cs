using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts.Views
{
    public class RoundButton : Button
    {
        public void RoundExistingButton(Button button)
        {
            // Create a GraphicsPath to define the shape of the button
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Set the radius for the rounded corners
            path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Set the button's region to the defined shape
            button.Region = new Region(path);
        }
    }
}
