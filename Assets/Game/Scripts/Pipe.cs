using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlappyBird.Player;
using NaughtyAttributes;

namespace SlappyBird.WorldSpace
{
    public class Pipe : MonoBehaviour
    {
        [SerializeField] List<Rigidbody2D> pipePieceList;
        //Vector2 poss;
        [SerializeField] private float magnitude = 1f;

        [Button("Exlode")]
        public void Explode()
        {
            foreach (var pipe in pipePieceList)
            {
                pipe.GetComponent<Rigidbody2D>().simulated = true;

                //pipe.AddForceAtPosition(Vector2.right, poss);
                //pipe.transform.Translate(GetRandomPos() * magnitude * Time.deltaTime);
                pipe.GetComponent<Rigidbody2D>().velocity = GetRandomPos();
                Destroy(pipe.gameObject,2f);
            }
        }

        private Vector3 GetRandomPos()
        {
            int i = Random.Range(-1, 2);
            return new Vector3(i, i);
        }


    }

}