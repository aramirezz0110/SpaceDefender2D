using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceDefender.UI
{
    public class MainUIController : MonoBehaviour
    {
        [Header("UI PANELS")]
        [SerializeField] private GameObject mainPanel;
        [SerializeField] private GameObject optionsPanel;
        [SerializeField] private GameObject creditsPanel;
        [SerializeField] private GameObject closeAppPanel;
        [Header("MAIN PANEL ELEMENTS")]
        [SerializeField] private Button playButton;
        [SerializeField] private Button optionsButton;
        [SerializeField] private Button creditsButton;
        [SerializeField] private Button closeAppButton;
        [SerializeField] private TMP_Text bestScoreText;
        [Header("OPTIONS PANEL ELEMENTS")]
        [SerializeField] private Button backToMainMenu1;
        [SerializeField] private Button restoreBestScore;
        [Header("CREDITS PANEL ELEMENTS")]
        [SerializeField] private Button backToMainMenu2;
        [Header("CLOSE APP PANEL ELEMENTS")]
        [SerializeField] private Button yesButton;
        [SerializeField] private Button cancelButton;

        private void Start()
        {
            ActivatePanel(mainPanel);
            LoadBestScore();
        }
        private void OnEnable() => AddListeners();
        private void AddListeners()
        {
            optionsButton?.onClick.AddListener(()=>ActivatePanel(optionsPanel));
            creditsButton?.onClick.AddListener(()=>ActivatePanel(creditsPanel));
            closeAppButton?.onClick.AddListener(()=>ActivatePanel(closeAppPanel));

            backToMainMenu1?.onClick.AddListener(() => ActivatePanel(mainPanel));
            restoreBestScore?.onClick.AddListener(RestoreBestScore);

            backToMainMenu2?.onClick.AddListener(() => ActivatePanel(mainPanel));

            yesButton?.onClick.AddListener(CloseApp);
            cancelButton?.onClick.AddListener(()=> ActivatePanel(mainPanel));
        }
        private void ActivatePanel(GameObject panel)
        {
            mainPanel?.SetActive(mainPanel.name.Equals(panel.name));
            optionsPanel?.SetActive(optionsPanel.name.Equals(panel.name));
            creditsPanel?.SetActive(creditsPanel.name.Equals(panel.name));
            closeAppPanel?.SetActive(closeAppPanel.name.Equals(panel.name));
        }
        private void LoadBestScore() => 
            bestScoreText.text ="BEST SCORE: "+PlayerPrefs.GetInt(PlayerPrefsRefs.BestScore,0);

        private void RestoreBestScore()
        {
            PlayerPrefs.SetInt(PlayerPrefsRefs.BestScore, 0);
            LoadBestScore();
        }
        private void CloseApp() => Application.Quit();
    }
}
