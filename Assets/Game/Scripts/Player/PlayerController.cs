using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlappyBird.PlayerInput;
using SlappyBird.UI;
using NaughtyAttributes;
using SlappyBird.WorldSpace;
using UnityEngine.SceneManagement;

namespace SlappyBird.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerControllerSettings playerSettings;   //RW
        [SerializeField] private Animator animator;
        [SerializeField] private Rigidbody2D rb;

        private const float maxYheight = 5.15f;
        private const float minYheight = -5.5f;

        private bool canMove = false;
        private bool isDead = false;

        private void Update()
        {
            HandleHeightBoundaries();
            CheckInputs();
            Move();
           

        }
        private void HandleHeightBoundaries()
        {
            if (transform.position.y < minYheight)
            {
                isDead = true;
                canMove = false;
                UIManager.Instance.SetActiveGameOverUI();
            }
        }
        private void Move()
        {
            if (!canMove && PlayerInputManager.IsClickDownAnything)
            {
                //first move
                canMove = !canMove;
                UIManager.Instance.SetDeactiveTapToStartUI();
                if (isDead)
                {
                    SceneManager.LoadScene(0);
                }
            }
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
            if (maxYheight > transform.position.y)
            {
                animator.SetBool(StringData.PRESSEDJUMP, true);
                rb.velocity = new Vector2(rb.velocity.x, playerSettings.JumpHeightY);

            }
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
                UIManager.Instance.UpdateScore(1);
                SoundManager.Instance.PlaySound();
            }
            if (collision.CompareTag(StringData.GROUND))
            {
                UIManager.Instance.SetActiveGameOverUI();
                SoundManager.Instance.PlayNooooo();
            }
        }




    }

}