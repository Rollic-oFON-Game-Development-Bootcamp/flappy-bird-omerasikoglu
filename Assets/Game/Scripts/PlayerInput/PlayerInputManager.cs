using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlappyBird.PlayerInput
{
    public class PlayerInputManager : MonoBehaviour
    {
        public float HorizontalInput { get; private set; }
        public float VerticalInput { get; private set; }

        public static bool IsClickingDown { get; private set; }
        public static bool IsClickingLeftDown { get; private set; }
        public static bool IsClickingRightDown { get; private set; }
        public static bool IsClickingLeftUp { get; private set; }
        public static bool IsClickingRightUp { get; private set; }
        public static bool IsClickingLeft { get; private set; }
        public static bool IsClickingRight { get; private set; }

        private void Update()
        {
            ReceiveAxisInputs();
            ReceiveClickInputs();
        }

        private void ReceiveClickInputs()
        {
            IsClickingRight = Input.GetMouseButton(1);
            IsClickingRightUp = Input.GetMouseButtonUp(1);
            IsClickingRightDown = Input.GetMouseButtonDown(1);

            IsClickingLeft = Input.GetMouseButton(0);
            IsClickingLeftUp = Input.GetMouseButtonUp(0);
            IsClickingLeftDown = Input.GetMouseButtonDown(0);

            IsClickingDown = IsClickingLeftDown || IsClickingRightDown;
        }

        private void ReceiveAxisInputs()
        {
            HorizontalInput = Input.GetAxisRaw(StringData.HORIZONTAL);
            VerticalInput = Input.GetAxisRaw(StringData.VERTICAL);
        }
    }
}
