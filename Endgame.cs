using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{
    public GameObject Portal1;
    public GameObject Portal2;
    public GameObject Portal3;
    public GameObject YouWinScreen;
    
    
    static public int level1 = 0;
    static public int level2 = 0;
    static public int level3 = 0;

    void Update()
    {
        closeLevel1();
        closeLevel2();
        closeLevel3();
        GameEnding();    
    }



    void closeLevel1()
    {
        Debug.Log(World1toLevelSelect.WorldOneLock);

        if (World1toLevelSelect.WorldOneLock == 1)
        {
            Portal1.SetActive(false);
            level1 = 1;
        }
        else if (World1toLevelSelect.WorldOneLock == 0)
        {
            Portal1.SetActive(true);
            level1 = 0;

        }
        

        
          
    }

    void closeLevel2()
    {
        Debug.Log(World2Exit.World2Lock);

        if (World2Exit.World2Lock == 1)
        {
            Portal2.SetActive(false);
            level2 = 1;
        }
        else if (World2Exit.World2Lock == 0)
        {
            Portal2.SetActive(true);
            level2 = 0;
        }
    
    
    }

    void closeLevel3()
    {
        Debug.Log(World3Exit.World3Lock);

        if (World3Exit.World3Lock == 1)
        {
            Portal3.SetActive(false);
            level3 = 1;

        }
        else if (World3Exit.World3Lock == 0)
        {
            Portal3.SetActive(true);
            level3 = 0;
        }



    }

    void GameEnding()
    {
        if (level1 == 1 && level2 == 1 && level3 == 1)
        {
            YouWinScreen.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            
        }
        else if (level1 == 0 && level2 == 0 && level3 == 0)
        {
            YouWinScreen.SetActive(false);
            
        }




    }







}
