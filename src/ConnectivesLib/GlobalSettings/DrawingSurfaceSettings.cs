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
        // Divisions
        // ------------
        public Color MajorDivisionsBackgroundColor { get; set; } = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);
        public Color MinorDivisionsBackgroundColor { get; set; } = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        public Color MajorDivisionsBorderLineColor { get; set; } = Color.FromArgb(alpha: 180, red: 250, green: 162, blue: 65);
        public Color MinorDivisionsBorderLineColor { get; set; } = Color.FromArgb(alpha: 120, red: 253, green: 219, blue: 181);

        public Length DistanceBetweenMajorDivisions { get; set; } = new Length{ Unit = LengthUnit.Inch, Measurement = 1 };
        public int MinorDivisionsBetweenMajorDivisions { get; set; } = 12;
    }
}
