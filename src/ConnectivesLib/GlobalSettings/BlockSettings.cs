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

        // ---------------
        // Dimensions
        // ------------
        public WidthMeasurement BlockBorderLineWidth { get; set; } = new WidthMeasurement { Unit = DistanceUnit.MilliMeter, Measurement = 0.08 };
    }
}
