using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public static bool isMenuHidden = false;
    public GameObject arStuff;
    public GameObject imageTarget;
    public GameObject mainMenu;
    public GameObject homeButton;

    public void ChangeMenuState()
    {
        if (isMenuHidden)
        {
            arStuff.SetActive(false);
            imageTarget.SetActive(false);
            mainMenu.SetActive(true);
            homeButton.SetActive(false);
            isMenuHidden = false;
        } else
        {
            arStuff.SetActive(true);
            imageTarget.SetActive(true);
            mainMenu.SetActive(false);
            homeButton.SetActive(true);
            isMenuHidden = true;
        }
    }

}
