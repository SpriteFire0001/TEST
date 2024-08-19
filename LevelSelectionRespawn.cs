using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectionRespawn : MonoBehaviour
{
    [SerializeField] private Transform Player;
    public Transform LSspawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.transform.position = LSspawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }
}
