using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

namespace SpaceDefender 
{
    public class GameUIManager : MonoBehaviour
    {
        [Header("UI PANELS")]
        [SerializeField] private GameObject hudPanel;
        [SerializeField] private GameObject gameOverPanel;

        [Header("HUD PANEL ELEMENTS")]
        [SerializeField] private TMP_Text scoreText;

        
        private void Start()
        {
            ActivatePanel(hudPanel);
        }

        public void UpdateScore(int score) => scoreText.text ="SCORE: "+score;
        public void GameOver()
        {
            ActivatePanel(gameOverPanel);
        }

        private void ActivatePanel(GameObject panel)
        {            
            hudPanel?.SetActive(hudPanel.name.Equals(panel.name));
            gameOverPanel?.SetActive(gameOverPanel.name.Equals(panel.name));
        }
    }
}

