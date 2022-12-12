using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDefender.Spawning
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] protected GameObject prefab;
        [SerializeField] protected Transform prefabParent;
        [SerializeField] protected float spawnWaitTime = 5f;
        public void StartSpawning()
        {

        }
        public void StopSpawning()
        {

        }
    }
}
