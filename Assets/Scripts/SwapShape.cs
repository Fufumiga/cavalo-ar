using UnityEngine;
using UnityEngine.UI;

public class SwapShape : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public Text textBox;
    bool isCube = true;

    public void SwapObject()
    {
        if (isCube)
        {
            isCube = false;
            cube.SetActive(false);
            sphere.SetActive(true);
            textBox.text = "Swap to Cube";
        }
        else
        {
            isCube = true;
            cube.SetActive(true);
            sphere.SetActive(false);
            textBox.text = "Swap to Sphere";
        }
    }
}
