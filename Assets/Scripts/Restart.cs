using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject panel;

    public void nextgame()
    {
        Time.timeScale = 1f;
        panel.SetActive(false);
    
   
        
    }
}
