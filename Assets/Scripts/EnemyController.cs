using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDefender.Enemy
{
    [RequireComponent(typeof(Collider2D))]
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;

        private void Update() => Movement();
        private void Movement()=> transform.Translate(Vector3.down * speed * Time.deltaTime);
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag(GameTags.Player.ToString()))
            {
                GameManager.Instance?.GameOver();
            }
            if (collision.gameObject.CompareTag(GameTags.Laser.ToString()))
            {
                GameManager.Instance?.EnemyDestroyedPoints();
                Destroy(gameObject);
            }
        }
    }
}
