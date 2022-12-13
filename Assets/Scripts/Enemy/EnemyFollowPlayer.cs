using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceDefender.Player;
namespace SpaceDefender.Enemy
{
    public class EnemyFollowPlayer : MonoBehaviour
    {
        [SerializeField] private float speed = 4f;
        private GameObject player;
                
        private void Start()
        {
            int randomMovement = Random.Range(0, 100);
            if (randomMovement<50)
            {
                player = FindObjectOfType<PlayerController>().gameObject;
            }            
        }
        private void Update()
        {
            FreeMovement();
            MoveToPlayer();
        }
        private void MoveToPlayer()
        {
            if(!player) return;

            float tempSpeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position,player.transform.position, tempSpeed);
        }
        private void FreeMovement()
        {
            if (player) return;

            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
}
