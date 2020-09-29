using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CavaloButtonController : MonoBehaviour
{
    public Button cavaloButton; // costume de referenciar o componente ao invés de tudo gameobject evita erro humano
    public Button danceButton;


    private void OnEnable()
    {
        SetsActivesons(true, cavaloButton, danceButton); // could add more butoins to more funcionalits
    }

    private void OnDisable()
    {
        SetsActivesons(false, cavaloButton, danceButton);
    }



    private void SetsActivesons(bool seraquesim, params Button[] butoins)
    { 
        butoins.ToList().ForEach( (eachOfButoins) => eachOfButoins.gameObject.SetActive(seraquesim) );
    }

}
