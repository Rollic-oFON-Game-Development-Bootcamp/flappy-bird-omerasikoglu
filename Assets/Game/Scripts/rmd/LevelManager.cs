using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using UnityEngine.SceneManagement;

namespace SlappyBird.Level
{
    public class LevelManager : Singleton<LevelManager>
    {

        private int currentLevel = 1;

        protected override void Awake()
        {
            currentLevel = PlayerPrefs.GetInt(StringData.CURRENTLEVEL);
            PlayerPrefs.SetInt(StringData.CURRENTLEVEL, currentLevel);
        }

        [Button]
        private void ResetLevelData()
        {
            PlayerPrefs.SetInt(StringData.CURRENTLEVEL, 1);
        }
        public void LoadNextScene()
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt(StringData.CURRENTLEVEL));
        }


    }
}
