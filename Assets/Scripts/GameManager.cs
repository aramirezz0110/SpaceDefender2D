using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDefender
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        private GameStatus gameStatus;
        private int score;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }

        public void GameOver()
        {
            Time.timeScale = 0f;
        }
        public void PlayGame()
        {
            Time.timeScale = 1f;
        }
        public void EnemyDestroyedPoints() => score += 8;
        public void CoinCollectedPoints() => score += 5;
    }
}
