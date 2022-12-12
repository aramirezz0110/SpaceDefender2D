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
        [Header("MOVEMENT CONFIG")]
        [SerializeField] private float verticalLimit = 4f;
        [SerializeField] private float horizontalLimit = 4f;

        private float horizontalInput;
        private float verticalInput;
        private Vector3 direction;

        public float HorizontalInput { get=> horizontalInput; set=> horizontalInput = value; }
        public float VerticalInput { get=> verticalInput; set=> verticalInput = value; }

        private void Update()
        {
            Movement();
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
        private void OnTriggerEnter2D(Collider2D collision)
        {
            
        }
    } 
}

