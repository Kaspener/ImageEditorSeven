using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEditorSeven.Models
{
    public class PolygonElement : Figures
    {
        private string points;
        private string strokeColor;
        private double strokeThickness;
        private string fillColor;

        public string Points
        {
            get => points;
            set => SetAndRaise(ref points, value);
        }
        public string StrokeColor
        {
            get => strokeColor;
            set => SetAndRaise(ref strokeColor, value);
        }
        public double StrokeThickness
        {
            get => strokeThickness;
            set => SetAndRaise(ref strokeThickness, value);
        }
        public string FillColor
        {
            get => fillColor;
            set => SetAndRaise(ref fillColor, value);
        }
    }
}
