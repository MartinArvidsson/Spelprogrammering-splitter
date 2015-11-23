using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    class Camera
    {
        private int fieldsize;
        int width;
        int height;
        private float particlesize = 0.02f;
        float scale = 1;
        public void setFieldSize(Viewport board)
        {
            width = board.Width;
            height = board.Height;

            if(width < height)
            {
                fieldsize = width;
            }
            else
            {
                fieldsize = height;
            }
        }

        public Vector2 Converttovisualcoords(Vector2 coords,Texture2D spark)
        {
            float visualX = coords.X * fieldsize - (spark.Width / 2) * scale;
            float visualY = coords.Y * fieldsize - (spark.Height / 2) * scale;
            return new Vector2(visualX, visualY);
        }

        public float Scale(Texture2D spark)
        {
            return scale = fieldsize * particlesize / spark.Width;
            
        }
    }
}
