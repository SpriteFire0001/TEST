using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World2Exit : MonoBehaviour
{
    public static int World2Lock = 0;
    public GameObject World2Door;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            World2Lock = 1;
            SceneManager.LoadScene("SampleScene");
        }
    }

}
