using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlappyBird.Player
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Player/PlayerControllerSettings")]
    public class PlayerControllerSettings : ScriptableObject
    {
        [SerializeField] private float playerSpeed;
        [SerializeField] private float rotateSpeed;

        public float PlayerSpeed => playerSpeed;
        public float RotateSpeed => rotateSpeed;

    }
}
