using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEditorSeven.Models
{
    public class EllipseElement : Figures
    {
        private string startPoint;
        private double width;
        private double height;
        private string strokeColor;
        private double strokeThickness;
        private string fillColor;

        public string StartPoint
        {
            get => startPoint;
            set => SetAndRaise(ref startPoint, value);
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
        public double Width
        {
            get => width;
            set => SetAndRaise(ref width, value);
        }
        public double Height
        {
            get => height;
            set => SetAndRaise(ref height, value);
        }
    }
}
