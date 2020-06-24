using System;
using System.Drawing;
using System.Text;

namespace FlyweightParticles
{
    /// <summary>
    /// Represents static particle without any dynamic properties 
    /// </summary>
    internal class Particle
    {
        /// <value>Represents bytes of picture that can have high resolution that thus requires lots of memory</value>
        byte[] particlePicture { get; set; }
        /// <value>Represents color of picture</value>
        Color color { get; set; }

        /// <summary>
        /// Creates Particle depending on it's type
        /// </summary>
        /// <param name="particleType">Type of particle</param>
        /// <exception cref="ArgumentException">Throws if type of particle is not implemented</exception>
        public Particle(ParticleType particleType)
        {
            switch (particleType)
            {
                case ParticleType.Dust:
                    SetProps(Encoding.ASCII.GetBytes("bdf34SD#@D"), Color.DarkGray);
                    break;
                case ParticleType.Fire:
                    SetProps(Encoding.ASCII.GetBytes("fgdf42##@D"), Color.Red);
                    break;
                default:
                    throw new ArgumentException("Unknown particle type");
            }
        }

        /// <summary>
        /// Sets properties depending on type
        /// </summary>
        /// <param name="particlePicture"></param>
        /// <param name="color"></param>
        private void SetProps(byte[] particlePicture, Color color)
        {
            this.particlePicture = particlePicture;
            this.color = color;
        }
    }
}