using Connectives.Common;
using System.Drawing;

namespace Connectives.GlobalSettings
{
    public static class DrawingSurfaceSettings
    {
        // ---------------
        // Background Surface
        // ------------
        public static Color SurfaceColor { get; set; }
            = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        // ---------------
        // Background Surface - Horizontal Divisions
        // ------------
        public static Color HorizontalMajorDivisionsBackgroundColor { get; set; }
            = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        public static Color HorizontalMinorDivisionsBackgroundColor { get; set; }
            = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        public static Color HorizontalMajorDivisionsBorderLineColor { get; set; }
            = Color.FromArgb(alpha: 180, red: 250, green: 162, blue: 65);

        public static Color HorizontalMinorDivisionsBorderLineColor { get; set; }
            = Color.FromArgb(alpha: 120, red: 253, green: 219, blue: 181);

        public static WidthMeasurement HorizontalMajorDivisionsBorderLineWidth { get; set; }
            = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.05 };

        public static WidthMeasurement HorizontalMinorDivisionsBorderLineWidth { get; set; }
            = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.01 };

        public static LengthMeasurement VerticalDistanceBetweenHorizontalMajorDivisions { get; set; }
            = new LengthMeasurement { Unit = DistanceUnit.Inch, Measurement = 4 };

        public static int MinorDivisionsBetweenHorizontalMajorDivisions { get; set; }
            = 0;

        // ---------------
        // Background Surface - Vertical Divisions
        // ------------
        public static Color VerticalMajorDivisionsBackgroundColor { get; set; }
            = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        public static Color VerticalMinorDivisionsBackgroundColor { get; set; }
            = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        public static Color VerticalMajorDivisionsBorderLineColor { get; set; }
            = Color.FromArgb(alpha: 180, red: 250, green: 162, blue: 65);

        public static Color VerticalMinorDivisionsBorderLineColor { get; set; }
            = Color.FromArgb(alpha: 120, red: 253, green: 219, blue: 181);

        public static WidthMeasurement VerticalMajorDivisionsBorderLineWidth { get; set; }
            = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.05 };

        public static WidthMeasurement VerticalMinorDivisionsBorderLineWidth { get; set; }
            = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.01 };

        public static LengthMeasurement HorizontalDistanceBetweenVerticalMajorDivisions { get; set; }
            = new LengthMeasurement { Unit = DistanceUnit.Inch, Measurement = 1 };

        public static int MinorDivisionsBetweenVerticalMajorDivisions { get; set; }
            = 12;

        // ---------------
        // Selection
        // ------------
        public static Color SelectionBoxColor { get; set; }
            = Color.FromArgb(alpha: 160, red: 228, green: 221, blue: 135);

        public static Color SelectionLineColor { get; set; }
            = Color.FromArgb(alpha: 180, red: 251, green: 70, blue: 70);

        public static WidthMeasurement SelectionLineWidth { get; set; }
            = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.10 };
    }
}
