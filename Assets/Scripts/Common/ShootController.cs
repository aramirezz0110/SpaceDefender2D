using SpaceDefender.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDefender
{
    public class ShootController : MonoBehaviour
    {
        [Header("SHOOT CONFIG")]
        [SerializeField] private GameObject laserPrefab;
        [SerializeField] private Transform laserOrigin;
        [SerializeField] private float fireRate = .5f;
        [SerializeField] private bool enemyShooting;

        private bool isShooting;
        private float canFire = -1f;

        private void Update()
        {
            if (Input.GetKey(KeyCode.Space) || enemyShooting)
            {
                Shoot();
            }
        }
        private void Shoot()
        {
            if (Time.time > canFire)
            {
                canFire = Time.time + fireRate;
                InstantiateLaser();
            }            
        }
        private void InstantiateLaser()
        {
            if (!laserOrigin || !laserPrefab) return;

            GameObject tempLaser = Instantiate(laserPrefab);
            tempLaser.transform.position = laserOrigin.position;

            if (!enemyShooting)
                GameAudioManager.Instance?.PlayLaserSounds();
        }

    }
}
