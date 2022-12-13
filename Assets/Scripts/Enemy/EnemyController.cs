using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDefender.Enemy
{
    [RequireComponent(typeof(Collider2D))]
    public class EnemyController : MonoBehaviour
    {     
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag(GameTags.Player.ToString()))
            {
                GameManager.Instance?.GameOver();
            }
            if (collision.gameObject.CompareTag(GameTags.Laser.ToString()))
            {
                GameManager.Instance?.EnemyDestroyedPoints();
                GameAudioManager.Instance?.PlayExplosionSounds();
                Destroy(gameObject);
            }
        }
    }    
}
