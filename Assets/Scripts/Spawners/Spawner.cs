using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace SpaceDefender.Spawning
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] protected GameObject prefab;
        [SerializeField] protected Transform prefabParent;
        [SerializeField] protected float spawnWaitTime = 5f;
        [SerializeField] protected float spawningOffset = 4f;

        protected bool isSpawning;
        protected Coroutine spawningCoroutine;
        public void StartSpawning() 
        {
            isSpawning = true;
            spawningCoroutine = StartCoroutine(SpawnPrefab());
        }
        public void StopSpawning() => StopCoroutine(spawningCoroutine);
        private IEnumerator SpawnPrefab()
        {
            while (isSpawning)
            {
                yield return new WaitForSeconds(spawnWaitTime);
                float xPosition = Random.Range(-spawningOffset, spawningOffset);
                Vector3 tempPosition = new Vector3(xPosition,prefabParent.position.y, prefabParent.position.z);
                GameObject tempPrefab = Instantiate(prefab);
                tempPrefab.transform.position = tempPosition;
                tempPrefab.transform.parent = prefabParent;
            }
        }
    }
}
