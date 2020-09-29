using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator anim;
    public void _PlayDance()
    {
        anim.Play("dance");
    }
}
