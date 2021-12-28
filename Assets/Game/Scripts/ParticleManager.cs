using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlappyBird
{
    public class ParticleManager : Singleton<ParticleManager>
    {
        [SerializeField] private ParticleSystem hitParticles;

        private void Awake()
        {
            PlayHitParticles(Vector2.zero);
        }
        public void PlayHitParticles(Vector2 position)
        {
            PlayParticles(position, hitParticles);
        }

        private void PlayParticles(Vector2 position, ParticleSystem selectedParticle)
        {
            ParticleSystem.Burst spawnBurst = selectedParticle.emission.GetBurst(0);
            int spawnCount = Random.Range(spawnBurst.minCount, spawnBurst.maxCount + 1);

            selectedParticle.transform.position = position;
            selectedParticle.Emit(new ParticleSystem.EmitParams
            {
                position = position,
                applyShapeToPosition = true
            }, spawnCount);
        }
    }
}
