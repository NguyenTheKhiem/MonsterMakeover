using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListVideos : MonoBehaviour
{
    [SerializeField] GameObject[] Videos;
    public void RandomVideo()
    {
        int randx = Random.Range(0, Videos.Length - 1);
        Instantiate(Videos[randx], transform.position, Quaternion.identity);
    }
}
