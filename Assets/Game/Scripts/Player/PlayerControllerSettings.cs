using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlappyBird.Player
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Player/PlayerControllerSettings")]
    public class PlayerControllerSettings : ScriptableObject
    {
        [SerializeField] private float movementSpeed;
        [SerializeField] private float jumpHeightY;
        [SerializeField] private float maxSpeed = 3f;

        public float MovementSpeed => movementSpeed;
        public float JumpHeightY => jumpHeightY;
        public float MaxSpeed => maxSpeed;
    }
}
