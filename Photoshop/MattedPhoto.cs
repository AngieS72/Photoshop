using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photoshop
{
    class MattedPhoto : Photo
    {
        public enum Colors
        {
            BLACK = 0,
            RED = 1,
            GREEN = 2,
            BLUE = 3,
            WHITE = 4
        }

        protected Colors _color;

        public MattedPhoto(float width,
                                        float height,
                                        Colors color) : base(width, height)
        {
            _color = color;
        }

        public Colors Color { get; set; }

        public override float Price => base.Price + 10;

       
        public override string ToString()
        {
            return base.ToString() + " " + _color;
        }             
    }    
}
