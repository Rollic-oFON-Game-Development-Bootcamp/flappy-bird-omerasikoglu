using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace SlappyBird.UI
{
    public class ScoreUI : Singleton<ScoreUI>
    {

        [SerializeField] private Transform youWinUI;
        [SerializeField] private List<Transform> levelList;

        private TextMeshProUGUI textMesh;

        

        private int currentScore = 0;
        private const int maxScore = 6;

        protected sealed override void Awake()
        {
            textMesh = transform.Find(StringData.BACKGROUND).Find(StringData.TEXT).GetComponent<TextMeshProUGUI>();
            youWinUI.gameObject.SetActive(false);

            UpdateScore();
        }

        public void UpdateScore(int amount = 0)
        {
            currentScore += amount;
            currentScore = Mathf.Clamp(currentScore, 0, maxScore);
            textMesh.SetText(currentScore.ToString() + " / " + maxScore.ToString());
            if (currentScore == maxScore)
            {
                youWinUI.gameObject.SetActive(true);
                Invoke("LoadNextScene", 2f);
            }
        }
        private void LoadNextScene()
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt(StringData.CURRENTLEVEL));
        }
    }
}
