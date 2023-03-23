using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ImageEditorSeven.Models
{
    public class LineElement : Figures
    {
        private string startPoint;
        private string endPoint;
        private string strokeColor;
        private double strokeThickness;
       


        public string StartPoint
        {
            get => startPoint;
            set => SetAndRaise(ref startPoint, value);
        }
        public string EndPoint
        {
            get => endPoint;
            set => SetAndRaise(ref endPoint, value);
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
    }
}
