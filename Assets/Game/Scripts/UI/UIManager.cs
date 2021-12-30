using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace SlappyBird.UI
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager Instance { get; private set; }
        private Transform youWinUI;
        private Transform tapToStartUI;

        private TextMeshProUGUI textMesh;

        private int currentScore = 0;

        

        protected void Awake()
        {
            Instance = this;

            youWinUI = transform.Find("YouWinUI");
            tapToStartUI = transform.Find("TapToStartUI");
            youWinUI.gameObject.SetActive(false);
            tapToStartUI.gameObject.SetActive(true);

            //UpdateScore();
        }
        private void Update()
        {
            
        }
        public void UpdateScore(int amount = 0)
        {
            currentScore += amount;
            
        }

        public void SetDisactiveTapToStartUI()
        {
            tapToStartUI.gameObject.SetActive(false);
        }

       
    }
}