using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheGameManager : MonoBehaviour

{
    public static bool paused;
    public static TheGameManager tgm;
    public GameObject gameOverPanel, pausePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
            if (paused)
            {
                tgm.pausePanel.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                tgm.pausePanel.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }
}
