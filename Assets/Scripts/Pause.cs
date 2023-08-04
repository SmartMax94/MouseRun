using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject panel;
    

    public void peuse()
    { 
        panel.SetActive(true);
        Time.timeScale = 0;

        


    } 
    }
    

