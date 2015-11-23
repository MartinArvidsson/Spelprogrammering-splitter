using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Game1
{
    class SplitterParticle
    {
        public Vector2 randomdirection;
        public float maxparticlespeed = 0.7f;

        public Vector2 pos = new Vector2(0.5f, 0.5f);
        public Vector2 velocity;
        public Vector2 acceleration = new Vector2(0.0f, 0.75f);

        public SplitterParticle(Texture2D spark, Random random) //Creates the random direction and speed
        {
            randomdirection = new Vector2((float)random.NextDouble() - 0.5f, (float)random.NextDouble() - 0.5f);
            //normalize to get it spherical vector with length 1.0
            randomdirection.Normalize();
            //add random length between 0 to maxparticlespeed
            randomdirection = randomdirection * ((float)random.NextDouble() * maxparticlespeed);
            velocity = randomdirection;
        }

        public void Updateposition(float elapsedtime)
        {
            velocity = elapsedtime * acceleration + velocity;
            pos = elapsedtime * velocity + pos;
        }
    }
}
