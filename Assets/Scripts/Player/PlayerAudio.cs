using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDefender.Player
{
    public class PlayerAudio : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private AudioClip laserAudioClip;
        [SerializeField] private AudioClip powerUpAudioClip;
        [SerializeField] private AudioClip explosionAudioClip;

        public void PlayLaserSound() => audioSource?.PlayOneShot(laserAudioClip);
        public void PlayPowerUpSound() => audioSource?.PlayOneShot(powerUpAudioClip);
        public void PlayExplosionSound() => audioSource?.PlayOneShot(explosionAudioClip);

    }
}
