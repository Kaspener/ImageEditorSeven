using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEditorSeven.Models
{
    public class PathElement : Figures
    {
        private string commands;
        private string strokeColor;
        private double strokeThickness;
        private string fillColor;

        public string Commands
        {
            get => commands;
            set => SetAndRaise(ref commands, value);
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
