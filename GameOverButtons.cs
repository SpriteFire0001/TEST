using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour
{
    public void ReturnToMainMenu()
    {
       
        Debug.Log(Endgame.level1);
        Debug.Log(Endgame.level2);
        Debug.Log(Endgame.level3);

        Endgame.level1 = 0;
        Endgame.level2 = 0;
        Endgame.level3 = 0;

        Debug.Log(World1toLevelSelect.WorldOneLock);
        Debug.Log(World2Exit.World2Lock);
        Debug.Log(World3Exit.World3Lock);

        World1toLevelSelect.WorldOneLock = 0;
        World2Exit.World2Lock = 0;
        World3Exit.World3Lock = 0;




        SceneManager.LoadScene("MainMenu");
    }
    
}
