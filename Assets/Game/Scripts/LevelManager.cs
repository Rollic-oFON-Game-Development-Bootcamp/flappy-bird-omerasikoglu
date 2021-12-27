using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

namespace SlappyBird.Level
{
    public class LevelManager : MonoBehaviour
    {
        private static LevelManager instance;
        public static LevelManager Instance => instance ??= new LevelManager();

        private int currentLevel = 1;

        private void Awake()
        {
            //if (PlayerPrefs.GetInt(StringData.CURRENTLEVEL) != null)
            //{
            //    currentLevel = PlayerPrefs.GetInt(StringData.CURRENTLEVEL);
            //}
            //else
            //{

            //}

            currentLevel = PlayerPrefs.GetInt(StringData.CURRENTLEVEL);
            PlayerPrefs.SetInt(StringData.CURRENTLEVEL, currentLevel);
        }

        [Button]
        private void ResetLevelData()
        {
            PlayerPrefs.SetInt(StringData.CURRENTLEVEL, 1);
        }
    }
}
