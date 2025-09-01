using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle
    {
        // Selber implementierte, read-only Eigenschaft
        private int _width;
        public int Width   // read-only
        {
            get { return _width; }
        }

        // Selber implementierte, read-write Eigenschaft
        private int _height;
        public int Height   // read-write
        {
            get { return _height; }
            set { _height = value; }
        }

        // Selber implementierte, write-only Eigenschaft
        private string _color;
        public string Color   // write-only
        {
            set { _color = value; }
        }

        // Automatisch implementierte, read-only Eigenschaft
        public int Id { get; } = new Random().Next(1, 1000);

        // Automatisch implementierte, read-write Eigenschaft
        public string Name { get; set; }

        // Automatisch implementierte, write-only Eigenschaft
        public string Secret { private get; set; }

        // Zwei expression-bodied Eigenschaften
        public int Area => Width * Height;          // nur get
        public string Info => $"Rectangle {Name}";  // Kurzschreibweise
    }
}