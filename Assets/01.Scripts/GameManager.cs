using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{

    private DateTime _sessionStartTime;
    private DateTime _sessionEndTime;

    // Start is called before the first frame update
    void Start()
    {
        _sessionStartTime = DateTime.Now;
        Debug.Log("���� ���� @: "+DateTime.Now);
    }

    private void OnApplicationQuit()
    {
        _sessionEndTime = DateTime.Now;
        TimeSpan timeDifference = _sessionEndTime.Subtract(_sessionStartTime);
    }

    private void OnGUI()
    {
        if(GUILayout.Button("Next Scene"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
