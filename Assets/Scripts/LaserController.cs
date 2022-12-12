using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDefender.Laser 
{
    public class LaserController : MonoBehaviour
    {
        [SerializeField] private float speed = 8f;

        private void Update() => Movement();
        private void Movement() => transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
