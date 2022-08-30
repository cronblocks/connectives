using System.Drawing;

namespace Connectives.GlobalSettings
{
    public class DrawingSurfaceSettings
    {
        public Color SurfaceColor { get; set; } = Color.FromArgb(alpha: 150, red: 228, green: 221, blue: 135);

        public Color MajorDivisionsColor { get; set; } = Color.FromArgb(alpha: 150, red: 250, green: 162, blue: 65);
        public Color MinorDivisionsColor { get; set; } = Color.FromArgb(alpha: 150, red: 253, green: 219, blue: 181);
    }
}
