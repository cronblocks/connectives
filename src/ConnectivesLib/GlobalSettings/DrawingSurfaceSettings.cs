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

        public Width HorizontalMajorDivisionsBorderLineWidth { get; set; } = new Width { Unit = DistanceUnit.MilliMeter, Measurement = 0.05 };
        public Width HorizontalMinorDivisionsBorderLineWidth { get; set; } = new Width { Unit = DistanceUnit.MilliMeter, Measurement = 0.01 };

        public Length VerticalDistanceBetweenHorizontalMajorDivisions { get; set; } = new Length { Unit = DistanceUnit.Inch, Measurement = 4 };
        public int MinorDivisionsBetweenHorizontalMajorDivisions { get; set; } = 0;

        // ---------------
        // Vertical Divisions
        // ------------
        public Color VerticalMajorDivisionsBackgroundColor { get; set; } = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);
        public Color VerticalMinorDivisionsBackgroundColor { get; set; } = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        public Color VerticalMajorDivisionsBorderLineColor { get; set; } = Color.FromArgb(alpha: 180, red: 250, green: 162, blue: 65);
        public Color VerticalMinorDivisionsBorderLineColor { get; set; } = Color.FromArgb(alpha: 120, red: 253, green: 219, blue: 181);

        public Width VerticalMajorDivisionsBorderLineWidth { get; set; } = new Width { Unit = DistanceUnit.MilliMeter, Measurement = 0.05 };
        public Width VerticalMinorDivisionsBorderLineWidth { get; set; } = new Width { Unit = DistanceUnit.MilliMeter, Measurement = 0.01 };

        public Length HorizontalDistanceBetweenVerticalMajorDivisions { get; set; } = new Length { Unit = DistanceUnit.Inch, Measurement = 1 };
        public int MinorDivisionsBetweenVerticalMajorDivisions { get; set; } = 12;

        // ---------------
        // Selection
        // ------------
        public Color SelectionLineColor { get; set; } = Color.FromArgb(alpha: 180, red: 251, green: 70, blue: 70);

        public Width SelectionLineWidth { get; set; } = new Width { Unit = DistanceUnit.MilliMeter, Measurement = 0.10 };
    }
}
