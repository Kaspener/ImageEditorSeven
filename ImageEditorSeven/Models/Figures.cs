using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ImageEditorSeven.Models
{
    [XmlInclude(typeof(LineElement))]
    [XmlInclude(typeof(PolylineElement))]
    [XmlInclude(typeof(PolygonElement))]
    [XmlInclude(typeof(RectangleElement))]
    [XmlInclude(typeof(EllipseElement))]
    [XmlInclude(typeof(PathElement))]
    public class Figures : AbstractNotifyPropertyChanged
    {
        private string name="";
        private string rotate="";
        private string scale = "";
        private string skew = "";
        private string center = "";

        public string Name
        {
            get => name;
            set => SetAndRaise(ref name, value);
        }
        public string Rotate
        {
            get => rotate;
            set => SetAndRaise(ref rotate, value);
        }
        public string Scale
        {
            get => scale;
            set => SetAndRaise(ref scale, value);
        }
        public string Skew
        {
            get => skew;
            set => SetAndRaise(ref skew, value);
        }
        public string Center
        {
            get => center;
            set => SetAndRaise(ref center, value);
        }
    }
}
