using Connectives.Common;
using System.Drawing;

namespace Connectives.GlobalSettings
{
    public class DrawingSurfaceSettings
    {
        // ---------------
        // Background Surface
        // ------------
        public Color SurfaceColor { get; set; } = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        // ---------------
        // Horizontal Divisions
        // ------------
        public Color HorizontalMajorDivisionsBackgroundColor { get; set; } = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);
        public Color HorizontalMinorDivisionsBackgroundColor { get; set; } = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        public Color HorizontalMajorDivisionsBorderLineColor { get; set; } = Color.FromArgb(alpha: 180, red: 250, green: 162, blue: 65);
        public Color HorizontalMinorDivisionsBorderLineColor { get; set; } = Color.FromArgb(alpha: 120, red: 253, green: 219, blue: 181);

        public Length HorizontalDistanceBetweenMajorDivisions { get; set; } = new Length{ Unit = LengthUnit.Inch, Measurement = 1 };
        public int HorizontalMinorDivisionsBetweenMajorDivisions { get; set; } = 12;
    }
}
