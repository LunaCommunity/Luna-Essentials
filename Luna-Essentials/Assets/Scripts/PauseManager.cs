using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
 
    /// <summary>
    ///The OnPause and OnResume actions are called when the application loses focus, and when the app regains focus 
    ///You can subscribe any method to these two actions.
    ///An example of something you might want to do is set the timescale to 0 when the application loses focus to stop anything from happening
    ///whilst the user isn't viewing the ad
    /// </summary>
    
    void Start()
    {
        // Luna.Unity.LifeCycle.OnPause += Pause; //Uncomment once Luna is installed
        // Luna.Unity.LifeCycle.OnResume += Resume; //Uncomment once Luna is installed
    }

    private void Resume()
    {
        Time.timeScale = 1;
    }

    private void Pause()
    {
        Time.timeScale = 0;
    }

}
