using Connectives.Common;
using System.Drawing;

namespace Connectives.GlobalSettings
{
    public class BlockSettings
    {
        // ---------------
        // Colors
        // ------------
        public Color BlockBorderColor { get; set; } = Color.FromArgb(alpha: 180, red: 250, green: 35, blue: 35);
        public Color BlockBorderSelectedColor { get; set; } = Color.FromArgb(alpha: 250, red: 250, green: 35, blue: 35);

        public Color ConnectionValidColor { get; set; } = Color.FromArgb(alpha: 180, red: 68, green: 188, blue: 10);
        public Color ConnectionInvalidColor { get; set; } = Color.FromArgb(alpha: 180, red: 254, green: 50, blue: 101);

        public Color ConnectionValidSelectedColor { get; set; } = Color.FromArgb(alpha: 250, red: 68, green: 188, blue: 10);
        public Color ConnectionInvalidSelectedColor { get; set; } = Color.FromArgb(alpha: 250, red: 254, green: 50, blue: 101);

        public Color InputPortColor { get; set; } = Color.FromArgb(alpha: 250, red: 82, green: 58, blue: 245);
        public Color OutputPortColor { get; set; } = Color.FromArgb(alpha: 250, red: 204, green: 220, blue: 10);
        public Color IOPortColor { get; set; } = Color.FromArgb(alpha: 250, red: 58, green: 163, blue: 171);

        // ---------------
        // Dimensions
        // ------------
        public WidthMeasurement BlockBorderLineWidth { get; set; } = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.08 };

        public WidthMeasurement ConnectionLineWidth { get; set; } = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.10 };
        public WidthMeasurement ConnectionSelectedLineWidth { get; set; } = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.13 };
    }
}
