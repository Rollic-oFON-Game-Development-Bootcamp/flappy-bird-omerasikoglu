using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlappyBird.PlayerInput;
using SlappyBird.UI;
using NaughtyAttributes;

namespace SlappyBird.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerControllerSettings playerSettings;   //RW
        [SerializeField] private Animator animator;

        private void Update()
        {
            Inputs();
        }

        private void Inputs()
        {
            if (PlayerInputManager.IsClickingDown)
            {
                JumpStarted();
            }
        }

        [Button]
        private void JumpStarted()
        {
            animator.SetBool(StringData.PRESSEDJUMP, true);
        }

        [Button]
        private void EndJumping()
        {
            animator.SetBool(StringData.PRESSEDJUMP, false);
        }
    }

}