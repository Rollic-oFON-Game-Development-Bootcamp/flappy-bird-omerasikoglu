using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

namespace SlappyBird.Camera
{
    public class CameraHandler : MonoBehaviour
    {
        [SerializeField] private CameraSettings cameraSettings;
        [SerializeField] private CinemachineVirtualCamera cinemachine;

        float moveSpeed = 30f;
        float orthographicSize;

    } 
}
