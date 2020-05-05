using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photoshop  
{
    class FramedPhoto :  Photo
    {
        // Material enumeration
        public enum Materials
        {
            PINE = 0,
            OAK = 1,
            STEEL = 2,
            SILVER = 3,
            GOLD = 4
        }

        // Style enumeration
        public enum Styles
        {
            SIMPLE =0,
            MODERN = 1,
            ANTIQUE =2,
            VINTAGE = 3,
            ECLECTIC =4
        }

        // FramedPhoto Instance Variables
        protected Materials _material;
        protected Styles _style;

        public FramedPhoto(float width,
                                         float height,
                                         Materials material,
                                         Styles style) : base(width, height)
        {
            _material = material;
            _style = style;
        }

        public Materials Material { get; set; }

        public Styles Style { get; set; }

        public override float Price => base.Price + 25;

        public override string ToString()
        {
            return base.ToString() + _material.ToString() + " "  +_style.ToString();
        }
    }   
}
