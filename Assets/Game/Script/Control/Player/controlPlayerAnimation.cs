using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace warehouse.Control
{
    public class controlPlayerAnimation : MonoBehaviour
    {
        public Animator Animation;

        private Move.movePlayer movePlayer;

        void Start()
        {
            movePlayer = GetComponent<Move.movePlayer>();

        }


        void Update()
        {
            characterAnimation();
        }

        void characterAnimation()
        {
            Animation.SetFloat("speed", movePlayer.direction.magnitude);
        }
    }
}
