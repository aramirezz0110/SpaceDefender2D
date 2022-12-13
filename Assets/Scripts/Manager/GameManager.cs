using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceDefender.Spawning;
namespace SpaceDefender
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        [Header("Spawners")]
        [SerializeField] private Spawner[] spawners;

        private GameStatus gameStatus;
        private int score;

        

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }
        public void PlayGame()
        {
            Time.timeScale = 1f;
            StartSpawning();
        }
        public void GameOver()
        {
            Time.timeScale = 0f;
            StopSpawning();
        }
        
        public void EnemyDestroyedPoints() => score += 8;
        public void CoinCollectedPoints() => score += 5;

        private void StartSpawning()
        {
            
        }
        private void StopSpawning()
        {
            
        }
    }
}
