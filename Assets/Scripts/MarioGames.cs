using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MarioGames : MonoBehaviour
{
    public VideoPlayer player;
    public GameObject cube;
    public GameObject sphere;
    public GameObject mariojogos;
    public void Pegadinha()
    {
        mariojogos.SetActive(true);
        player.Play();
    }
}
