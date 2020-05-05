using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photoshop
{
    class Photo
    {
        // Constants
        const float EIGHTBYTEN = 3.99F;
        const float TENBYTWELVE = 5.99F;
        const float DEFAULTPRICE = 9.99F;

            // Instance variables
        protected float _width;
        protected float _height;


        public Photo(float width, float height)
        {
            _width = width;
            _height = height;
        }

        public float Width { get; set; }
       
        public float Height { get; set; }
       
        public virtual float Price
        {
            get
            {
                if ((_width == 8) && (_height == 10))
                {
                    return EIGHTBYTEN;
                }
                else if ((_width ==10) && (_height == 12))
                {
                    return TENBYTWELVE;
                }
                else
                {
                    return DEFAULTPRICE;
                }
            }
        }

        public override string ToString()
        {
            return _width.ToString() + " x " + _height.ToString() + " ";
        }
    }
}