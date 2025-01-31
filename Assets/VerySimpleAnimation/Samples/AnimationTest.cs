﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VerySimpleAnimation.Sample
{
    public class AnimationTest : MonoBehaviour
    {
        [SerializeField]
        private Animator animator = default;
        [SerializeField]
        AnimationListPlayer animationListPlayer = default;

        private int animationIndex;

        private void Start()
        {
            animationListPlayer.Init(animator);
        }

        public void PlayNextAnimation()
        {
            if (animationListPlayer != null)
            {
                animationListPlayer.Play(++animationIndex);
            }
        }

        public void PlayDelayNextAnimation()
        {
            if (animationListPlayer != null)
            {
                animationListPlayer.PlayDelay(++animationIndex, 3f);
            }
        }

        public void PlayQueueNextAnimation()
        {
            if (animationListPlayer != null)
            {
                animationListPlayer.PlayQueue(++animationIndex);
            }
        }
    }
}
