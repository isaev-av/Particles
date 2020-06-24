using System;
using System.Collections.Generic;

namespace FlyweightParticles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DynamicParticle> dynamicParticles = new List<DynamicParticle>
            {
                new DynamicParticle(ParticleType.Dust, new Vector(), 12.2),
                new DynamicParticle(ParticleType.Fire, new Vector(), 14.2),
                new DynamicParticle(ParticleType.Fire, new Vector(), 16),
                new DynamicParticle(ParticleType.Dust, new Vector(), 12.2),
                new DynamicParticle(ParticleType.Fire, new Vector(), 3)
            };
        }
    }
}
