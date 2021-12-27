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
        [SerializeField] private PlayerInputData inputData;                 //readonly
        [SerializeField] private Animator animator;

        public List<GameObject> asd;


        private void Awake()
        {

        }

        private void Start()
        {
           
        }

        
        private void Update()
        {
            if (inputData.isClickingRightDown )
            {
                StartJump();
            } 
            
            if (inputData.isClickingLeftDown )
            {
                EndJumping();
            }
        }
        [Button]
        public void StartJump()
        {
            animator.SetBool("isJumping",true);
        }

        [Button]
        public void EndJumping()
        {
            animator.SetBool("isJumping", false);
        }
    }

}