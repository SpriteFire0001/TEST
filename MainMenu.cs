using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ReturnToMainMenu()
    {
        Debug.Log(Endgame.level1);
        Debug.Log(Endgame.level2);
        Debug.Log(Endgame.level3);
        
        Endgame.level1 = 0;
        Endgame.level2 = 0;
        Endgame.level3 = 0;
        

        
        SceneManager.LoadScene("MainMenu");
        
    
    
    
    
    
    
    }
}
