using Connectives.Common;
using System.Drawing;

namespace Connectives.GlobalSettings
{
    public class BlockSettings
    {
        // ---------------
        // Colors
        // ------------
        public Color BlockBorderColor { get; set; } = Color.FromArgb(alpha: 200, red: 250, green: 35, blue: 35);

        public Color ConnectionValidColor { get; set; } = Color.FromArgb(alpha: 200, red: 68, green: 188, blue: 10);
        public Color ConnectionInvalidColor { get; set; } = Color.FromArgb(alpha: 200, red: 254, green: 50, blue: 101);

        // ---------------
        // Dimensions
        // ------------
        public WidthMeasurement BlockBorderLineWidth { get; set; } = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.08 };
    }
}
