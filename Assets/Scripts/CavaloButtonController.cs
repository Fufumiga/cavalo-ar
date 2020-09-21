using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CavaloButtonController : MonoBehaviour
{
    public GameObject cavaloButton;

    private void OnEnable()
    {
        cavaloButton.SetActive(true);
    }

    private void OnDisable()
    {
        cavaloButton.SetActive(false);
    }
}
