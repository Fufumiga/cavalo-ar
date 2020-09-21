using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public static bool isMenuHidden = false;
    public GameObject arStuff;
    public GameObject imageTracker;
    public GameObject mainMenu;
    public GameObject homeButton;
    public GameObject cavaloButton;
    public void ChangeMenuState()
    {
        if (isMenuHidden)
        {
            arStuff.SetActive(false);
            imageTracker.SetActive(false);
            mainMenu.SetActive(true);
            homeButton.SetActive(false);
        } else
        {
            arStuff.SetActive(true);
            imageTracker.SetActive(true);
            mainMenu.SetActive(false);
            homeButton.SetActive(true);
        }
    }

}
