using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlappyBird.PlayerInput;
using SlappyBird.UI;
using NaughtyAttributes;
using System;

namespace SlappyBird.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerControllerSettings playerSettings;   //RW
        [SerializeField] private Animator animator;
        [SerializeField] private Rigidbody2D rb;

        private void Update()
        {
            Inputs();
            Move();
        }

        private void Move()
        {
            rb.velocity = Vector2.right * Time.deltaTime * playerSettings.MovementSpeed;
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