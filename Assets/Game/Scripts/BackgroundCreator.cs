using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

namespace SlappyBird.BackgroundCreater
{
    public class BackgroundCreator : MonoBehaviour
    {
        [SerializeField] private GameObject pfBackground;
        [SerializeField] private List<GameObject> backgroundList;

        [ShowNonSerializedField] private Vector2 currentPosition = new Vector2(-2.85f, 0f);
        [ShowNonSerializedField] private float distanceBetweenPrefabs = 5.7f; //prefab x distance

        [Button("Create BG")]
        private void Create()
        {
            GameObject bg = Instantiate(pfBackground, currentPosition, Quaternion.identity);
            bg.transform.SetParent(transform);
            backgroundList.Add(bg);
            currentPosition += Vector2.right * distanceBetweenPrefabs;
        }

        [Button("Remove BG")]
        private void RemoveRoad()
        {
            if (backgroundList.Count == 0)
            {
                Debug.LogError("No image is here!");
            }
            else
            {
                DestroyImmediate(backgroundList[backgroundList.Count - 1]);
                currentPosition -= Vector2.right * distanceBetweenPrefabs;
                backgroundList.RemoveAt(backgroundList.Count - 1);
            }
        }
    }
}