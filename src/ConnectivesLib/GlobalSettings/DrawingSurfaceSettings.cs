using Connectives.Common;
using System.Drawing;

namespace Connectives.GlobalSettings
{
    public class DrawingSurfaceSettings
    {
        // ---------------
        // Colors - Background
        // ------------
        public Color SurfaceBackgroundColor { get; set; } = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        // ---------------
        // Colors - Grid
        // ------------
        public Color HorizontalMajorDivisionsBackgroundColor { get; set; } = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);
        public Color HorizontalMinorDivisionsBackgroundColor { get; set; } = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);
        public Color HorizontalMajorDivisionsBorderLineColor { get; set; } = Color.FromArgb(alpha: 180, red: 250, green: 162, blue: 65);
        public Color HorizontalMinorDivisionsBorderLineColor { get; set; } = Color.FromArgb(alpha: 120, red: 253, green: 219, blue: 181);

        public Color VerticalMajorDivisionsBackgroundColor { get; set; } = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);
        public Color VerticalMinorDivisionsBackgroundColor { get; set; } = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);
        public Color VerticalMajorDivisionsBorderLineColor { get; set; } = Color.FromArgb(alpha: 180, red: 250, green: 162, blue: 65);
        public Color VerticalMinorDivisionsBorderLineColor { get; set; } = Color.FromArgb(alpha: 120, red: 253, green: 219, blue: 181);

        // ---------------
        // Colors - Selection
        // ------------
        public Color SelectionBoxFillColor { get; set; } = Color.FromArgb(alpha: 160, red: 228, green: 221, blue: 135);
        public Color SelectionLineColor { get; set; } = Color.FromArgb(alpha: 180, red: 251, green: 70, blue: 70);

        // ---------------
        // Dimensions - Grid
        // ------------
        public WidthMeasurement HorizontalMajorDivisionsBorderLineWidth { get; set; } = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.05 };
        public WidthMeasurement HorizontalMinorDivisionsBorderLineWidth { get; set; } = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.01 };

        public WidthMeasurement VerticalMajorDivisionsBorderLineWidth { get; set; } = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.05 };
        public WidthMeasurement VerticalMinorDivisionsBorderLineWidth { get; set; } = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.01 };

        public LengthMeasurement VerticalDistanceBetweenHorizontalMajorDivisions { get; set; } = new LengthMeasurement { Unit = DistanceUnit.Inch, Measurement = 4 };
        public LengthMeasurement HorizontalDistanceBetweenVerticalMajorDivisions { get; set; } = new LengthMeasurement { Unit = DistanceUnit.Inch, Measurement = 1 };

        public int MinorDivisionsBetweenHorizontalMajorDivisions { get; set; } = 0;
        public int MinorDivisionsBetweenVerticalMajorDivisions { get; set; } = 12;

        // ---------------
        // Dimensions - Selection
        // ------------
        public WidthMeasurement SelectionLineWidth { get; set; } = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.10 };
    }
}
