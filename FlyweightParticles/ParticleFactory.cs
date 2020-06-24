using System;
using System.Collections.Generic;
using System.Drawing;

namespace FlyweightParticles
{
    /// <summary>
    /// Factory for creating static properties of dynamic particles
    /// </summary>
    internal static class ParticleFactory
    {
        static Dictionary<ParticleType, Particle> particlesCache = new Dictionary<ParticleType, Particle>();

        /// <summary>
        /// Gets simple static particle from cache or creates a new one if it's not cached yet
        /// </summary>
        /// <param name="particleType">Type of particle that needs to be created</param>
        /// <returns>Simple static particle</returns>
        public static Particle create(ParticleType particleType)
        {
            if (!particlesCache.ContainsKey(particleType))
            {
                particlesCache.Add(particleType, new Particle(particleType));
            }
            return particlesCache[particleType];
        }
    }
}