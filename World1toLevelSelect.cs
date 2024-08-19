using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World1toLevelSelect : MonoBehaviour
{
    public static int WorldOneLock = 0;
    public GameObject Door;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            WorldOneLock = 1;
            SceneManager.LoadScene("SampleScene");
            
        }
    
    
    
    
    
    
    }
}
