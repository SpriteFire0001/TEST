using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RespawnWorld2 : MonoBehaviour
{
    public GameObject HP1, HP2, HP3;
    public GameObject GameOverScreen;

    [SerializeField] private Transform player;
    [SerializeField] private Transform RespawnPoint;
    [SerializeField] private Transform GameOverLocation;

    public float HealthPoints = 0;

    void Start()
    {
        HP1.SetActive(true);
        HP2.SetActive(true);
        HP3.SetActive(true);
        HealthPoints = 0;
        GameOverScreen.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = RespawnPoint.transform.position;
            Physics.SyncTransforms();
            HealthPoints++;
            if (HealthPoints == 1)
            {
                HP1.SetActive(false);
            }
            if (HealthPoints == 2)
            {
                HP2.SetActive(false);
            }
            if (HealthPoints == 3)
            {
                player.transform.position = GameOverLocation.transform.position;
                Physics.SyncTransforms();
                GameOverScreen.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        
        
        
        
        
        
        }
    }







}
