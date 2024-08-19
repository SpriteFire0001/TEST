using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World3Exit : MonoBehaviour
{
    public static int World3Lock = 0;
    public GameObject World3Door;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            World3Lock = 1;
            SceneManager.LoadScene("SampleScene");
        }
    }







}
