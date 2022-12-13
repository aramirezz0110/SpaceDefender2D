using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDefender
{
    public class GameAudioManager : MonoBehaviour
    {
        public static GameAudioManager Instance;
        
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private AudioClip explosionSound;

        private void Awake()
        {
            if(Instance == null)
                Instance = this;
            else 
                Destroy(gameObject);
        }

        public void PlayExplosionSounds() => audioSource?.PlayOneShot(explosionSound);
    }
}
