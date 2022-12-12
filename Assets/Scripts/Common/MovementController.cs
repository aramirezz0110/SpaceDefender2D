using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDefender
{
    public class MovementController : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;
        [SerializeField] private Direction direction;

        private void Update() => Movement();
        private void Movement()=> transform.Translate(GetMovementDirection(direction)*speed*Time.deltaTime);
        private Vector3 GetMovementDirection(Direction customDirection)
        {
            Vector3 tempDirection= Vector3.zero;
            switch (customDirection)
            {
                case Direction.Left:
                    tempDirection = Vector3.left;
                    break;
                case Direction.Right:
                    tempDirection = Vector3.right;
                    break;
                case Direction.Up:
                    tempDirection = Vector3.up;
                    break;
                case Direction.Down:
                    tempDirection = Vector3.down;
                    break;
                default: break;
            }
            return tempDirection;
        }
    }
}
