using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlappyBird.PlayerInput
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Input/Data")]
    public class PlayerInputData : ScriptableObject
    {
        public float horizontalInput;
        public float verticalInput;

        public bool isClickingRight;
        public bool isClickingLeft;

        public bool isClickingRightUp;
        public bool isClickingLeftUp;

        public bool isClickingRightDown;
        public bool isClickingLeftDown;

    } 
}
