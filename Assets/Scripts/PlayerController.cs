using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDefender.Player 
{
    [RequireComponent(typeof(Collider2D))]
    public class PlayerController : MonoBehaviour
    {
        [Header("PLAYER CONFIG")]
        [SerializeField] private float speed = 3f;
        [Header("SHOOT CONFIG")]
        [SerializeField] private float fireRate = .5f;
        [SerializeField] private Transform laserParent;
        [SerializeField] private GameObject laserPrefab;
        [Header("MOVEMENT CONFIG")]
        [SerializeField] private float verticalLimit = 4f;
        [SerializeField] private float horizontalLimit = 4f;
        

        private float horizontalInput;
        private float verticalInput;

        private bool isShooting;
        private float canFire = -1f;

        private Vector3 direction;

        public float HorizontalInput { get=> horizontalInput; set=> horizontalInput = value; }
        public float VerticalInput { get=> verticalInput; set=> verticalInput = value; }
        public bool IsShooting { set=> isShooting= value; }

        private void Update()
        {
            Movement();
            FireLaser();
        }
        private void Movement()
        {
            direction = new Vector3(horizontalInput, verticalInput);
            transform.Translate(direction*speed*Time.deltaTime);
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y,-verticalLimit, 0));
            if (transform.position.x >= horizontalLimit)
            {
                transform.position = new Vector3(horizontalLimit, transform.position.y, 0);
            }
            else if (transform.position.x <= -horizontalLimit)
            {
                transform.position = new Vector3(-horizontalLimit, transform.position.y, 0);
            }
        }
        private void FireLaser()
        {
            if (isShooting && Time.time > canFire)
            {
                canFire = Time.time + fireRate;
                InstantiateLaser();
            }
        }
        private void InstantiateLaser()
        {
            if (!laserParent || !laserPrefab) return;

            GameObject tempLaser = Instantiate(laserPrefab);
            tempLaser.transform.position = transform.position;
            tempLaser.transform.parent = laserParent;
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag(GameTags.Enemy.ToString()))
            {
                GameManager.Instance?.GameOver();
            }
            if (collision.gameObject.CompareTag(GameTags.Collectable.ToString()))
            {
                GameManager.Instance?.CoinCollectedPoints();
            }
        }
    } 
}

