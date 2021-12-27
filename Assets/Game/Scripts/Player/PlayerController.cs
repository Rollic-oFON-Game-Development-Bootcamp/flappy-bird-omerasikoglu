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

        
        public List<GameObject> asd;


        private void Awake()
        {

        }

        private void Start()
        {
           
        }

        
        private void Update()
        {
            if (inputData.isClickingRight || inputData.isClickingLeft)
            {
                Jump();
            }
        }
        [Button]
        private void Jump()
        {

        }
    }

}