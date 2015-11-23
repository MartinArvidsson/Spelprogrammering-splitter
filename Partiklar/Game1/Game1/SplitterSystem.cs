using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    class SplitterSystem
    {
        //Array
        private int numberofparticles = 100;

        public SplitterParticle[] particles;
        private static Random rand = new Random();

        public SplitterSystem(Texture2D spark)
        {
            particles = new SplitterParticle[numberofparticles]; //For each in the array creates a new particle to bounce around
            for (int i = 0; i < particles.Length; i++)
            {
                particles[i] = new SplitterParticle(spark, rand);
            }
        }
    }
}
