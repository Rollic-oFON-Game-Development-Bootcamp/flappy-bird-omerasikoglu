using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

namespace SlappyBird.WorldSpace
{
    public class BackgroundCreator : MonoBehaviour
    {
        [SerializeField] private GameObject pfBackgroundEmpty;
        [SerializeField] private List<GameObject> pfBackgroundTypeList;
        [SerializeField] private List<GameObject> backgroundList;

        [ShowNonSerializedField] private Vector2 currentPosition = new Vector2(-2.85f, 0f);
        [ShowNonSerializedField] private float distanceBetweenBGs = 5.7f; //prefab x distance

        [Button("Create BG")]
        private void Create()
        {
            int randomIndex = UnityEngine.Random.Range(0, 3);
            GameObject bg = Instantiate(pfBackgroundTypeList[randomIndex], currentPosition, Quaternion.identity);
            bg.transform.SetParent(transform);
            backgroundList.Add(bg);
            currentPosition += Vector2.right * distanceBetweenBGs;
        }

        [Button("Remove BG")]
        private void RemoveRoad()
        {
            if (backgroundList.Count == 0)
            {
                Debug.LogError("No image is here!");

                if (transform.childCount != 0)
                {
                    //for missing object errors, sometimes list count and childcount missmatch
                    DestroyImmediate(transform.GetChild(0).gameObject);
                }
            }
            else
            {
                DestroyImmediate(backgroundList[backgroundList.Count - 1]);
                currentPosition -= Vector2.right * distanceBetweenBGs;
                backgroundList.RemoveAt(backgroundList.Count - 1);
            }
            if (backgroundList.Count == 1)
            {
                //hard code
                currentPosition = new Vector2(2.85f, 0f);
            }
        }
    }
}