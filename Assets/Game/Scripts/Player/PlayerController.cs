using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlappyBird.PlayerInput;
using SlappyBird.UI;
using NaughtyAttributes;
using SlappyBird.WorldSpace;

namespace SlappyBird.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerControllerSettings playerSettings;   //RW
        [SerializeField] private Animator animator;
        [SerializeField] private Rigidbody2D rb;


        private bool canMove = false;


        private void Awake()
        {
            Time.timeScale = 0;
        }

        private void Update()
        {
            FirstMove();
            CheckInputs();
            Move();
        }

        private void FirstMove()
        {
            if (!canMove && PlayerInputManager.IsClickDownAnything)
            {
                canMove = !canMove;
                CheckTimeScale();
                UIManager.Instance.SetDisactiveTapToStartUI();
            }
        }

        private void Move()
        {
            if (canMove && rb.velocity.x < playerSettings.MaxSpeed)
            {
                //3f'e kadar hızlansın sonra hızı sabit kalsın
                rb.velocity += Vector2.right * playerSettings.MovementSpeed * Time.deltaTime;
            }
        }

        private void CheckInputs()
        {
            if (PlayerInputManager.IsClickingDown)
            {
                JumpPressed();
            }

        }

        [Button]
        private void JumpPressed()
        {
            animator.SetBool(StringData.PRESSEDJUMP, true);
            rb.velocity = new Vector2(rb.velocity.x, playerSettings.JumpHeightY);

        }

        [Button]
        private void JumpPressEnded()
        {
            animator.SetBool(StringData.PRESSEDJUMP, false);
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Pipe pipe = collision.GetComponent<Pipe>();
            if (pipe != null)
            {
                pipe.Explode();
                //UIManager.Instance.UpdateScore(1);
            }
        }
        private void CheckTimeScale()
        {
            Time.timeScale = canMove ? 1f : 0f;
        }
    }

}