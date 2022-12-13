using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDefender.Enemy
{
    [RequireComponent(typeof(Collider2D))]
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private GameObject explosionPrefab;
        private bool explosionInstantiated;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag(GameTags.Player.ToString()))
            {
                GameManager.Instance?.GameOver();
                ExplosionEffect();
            }
            if (collision.gameObject.CompareTag(GameTags.Laser.ToString()))
            {
                GameManager.Instance?.EnemyDestroyedPoints();
                GameAudioManager.Instance?.PlayExplosionSounds();
                ExplosionEffect();
                Destroy(gameObject,.5f);
            }
        }
        private void ExplosionEffect()
        {
            if (!explosionPrefab || explosionInstantiated) return; 
            GameObject tempExplosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            tempExplosion.transform.parent = gameObject.transform;
            GetComponent<Collider2D>().enabled = false;
            explosionInstantiated = true;            
        } 
    }    
}
