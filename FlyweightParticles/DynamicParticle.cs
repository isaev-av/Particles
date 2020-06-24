using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace FlyweightParticles
{
    /// <summary>
    /// Represents dynamic particle that can be places in game world
    /// </summary>
    class DynamicParticle
    {
        Particle particle;
        Vector vector;
        double speed;

        public DynamicParticle(ParticleType particleType, Vector vector, double speed)
        {
            this.vector = vector;
            this.speed = speed;
            particle = ParticleFactory.create(particleType);
        }
    }
}
