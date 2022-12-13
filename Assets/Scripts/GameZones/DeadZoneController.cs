using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDefender.GameZones
{
    
}
[RequireComponent(typeof(Collider2D))]
public class DeadZoneController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) => Destroy(collision.gameObject);
    private void OnCollisionEnter2D(Collision2D collision) => Destroy(collision.gameObject);
}
