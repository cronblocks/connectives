using System.Drawing;

namespace Connectives.GlobalSettings
{
    public class DrawingSurfaceSettings
    {
        public Color SurfaceColor { get; set; } = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        public Color MajorDivisionsColor { get; set; }
        public Color MinorDivisionsColor { get; set; }
    }
}
