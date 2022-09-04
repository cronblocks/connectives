using Connectives.Common;
using System.Drawing;

namespace Connectives.GlobalSettings
{
    public class DrawingSurfaceSettings
    {
        // ---------------
        // Background Surface
        // ------------
        public Color SurfaceColor { get; set; }
            = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        // ---------------
        // Background Surface - Horizontal Divisions
        // ------------
        public Color HorizontalMajorDivisionsBackgroundColor { get; set; }
            = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        public Color HorizontalMinorDivisionsBackgroundColor { get; set; }
            = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        public Color HorizontalMajorDivisionsBorderLineColor { get; set; }
            = Color.FromArgb(alpha: 180, red: 250, green: 162, blue: 65);

        public Color HorizontalMinorDivisionsBorderLineColor { get; set; }
            = Color.FromArgb(alpha: 120, red: 253, green: 219, blue: 181);

        public WidthMeasurement HorizontalMajorDivisionsBorderLineWidth { get; set; }
            = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.05 };

        public WidthMeasurement HorizontalMinorDivisionsBorderLineWidth { get; set; }
            = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.01 };

        public LengthMeasurement VerticalDistanceBetweenHorizontalMajorDivisions { get; set; }
            = new LengthMeasurement { Unit = DistanceUnit.Inch, Measurement = 4 };

        public int MinorDivisionsBetweenHorizontalMajorDivisions { get; set; }
            = 0;

        // ---------------
        // Background Surface - Vertical Divisions
        // ------------
        public Color VerticalMajorDivisionsBackgroundColor { get; set; }
            = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        public Color VerticalMinorDivisionsBackgroundColor { get; set; }
            = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        public Color VerticalMajorDivisionsBorderLineColor { get; set; }
            = Color.FromArgb(alpha: 180, red: 250, green: 162, blue: 65);

        public Color VerticalMinorDivisionsBorderLineColor { get; set; }
            = Color.FromArgb(alpha: 120, red: 253, green: 219, blue: 181);

        public WidthMeasurement VerticalMajorDivisionsBorderLineWidth { get; set; }
            = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.05 };

        public WidthMeasurement VerticalMinorDivisionsBorderLineWidth { get; set; }
            = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.01 };

        public LengthMeasurement HorizontalDistanceBetweenVerticalMajorDivisions { get; set; }
            = new LengthMeasurement { Unit = DistanceUnit.Inch, Measurement = 1 };

        public int MinorDivisionsBetweenVerticalMajorDivisions { get; set; }
            = 12;

        // ---------------
        // Selection
        // ------------
        public Color SelectionBoxColor { get; set; }
            = Color.FromArgb(alpha: 160, red: 228, green: 221, blue: 135);

        public Color SelectionLineColor { get; set; }
            = Color.FromArgb(alpha: 180, red: 251, green: 70, blue: 70);

        public WidthMeasurement SelectionLineWidth { get; set; }
            = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.10 };
    }
}
