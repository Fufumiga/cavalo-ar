using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameTimeEvents : MonoBehaviour
{
    [SerializeField] private AudioSource ednaldoOST;

    public void _PlayEdnaldoOST()
    {
        print("playing ost");
        ednaldoOST.Play();
    }
}
