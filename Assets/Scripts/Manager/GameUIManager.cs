using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SpaceDefender 
{
    public class GameUIManager : MonoBehaviour
    {
        [Header("UI PANELS")]
        [SerializeField] private GameObject mainPanel;
        [SerializeField] private GameObject hudPanel;
        [SerializeField] private GameObject gameOverPanel;

        [Header("MAIN PANEL ELEMENTS")]
        [SerializeField] private Button playButton;

        [Header("HUD PANEL ELEMENTS")]
        [SerializeField] private TMP_Text scoreText;

        [Header("GAME OVER PANEL ELEMENTS")]
        [SerializeField] private Button gameOverButton;

        private void ActivatePanel(GameObject panel)
        {
            mainPanel?.SetActive(mainPanel.name.Equals(panel.name));
            hudPanel?.SetActive(hudPanel.name.Equals(panel.name));
            gameOverPanel?.SetActive(gameOverPanel.name.Equals(panel.name));
        }

    }
}

