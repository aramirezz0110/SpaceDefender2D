using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceDefender.Spawning;
namespace SpaceDefender
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        [Header("SPAWNER REFERENCES")]
        [SerializeField] private Spawner[] spawners;
        [Header("SCRIPTS REFERENCES")]
        [SerializeField] private GameUIManager gameUIManager;
                
        private int score;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }
        private void Start()
        {
            PlayGame();
            gameUIManager?.UpdateScore(score);
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
            gameUIManager?.GameOver(score);
            
            if(score> PlayerPrefs.GetInt(PlayerPrefsRefs.BestScore))
            {
                PlayerPrefs.SetInt(PlayerPrefsRefs.BestScore, score);
            }
        }        
        public void EnemyDestroyedPoints()
        {
            score += 8;
            gameUIManager?.UpdateScore(score);
        }
        public void CoinCollectedPoints()
        {
            score += 5;
            gameUIManager?.UpdateScore(score);
        }
        private void StartSpawning()
        {
            foreach (Spawner spawner in spawners)
            {
                spawner.StartSpawning();
            }
        }
        private void StopSpawning()
        {
            foreach (Spawner spawner in spawners)
            {
                spawner.StopSpawning();
            }
        }
    }
}
