using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PauseButton : MonoBehaviour
{

    public Button pauseButton;
    public GameObject resumePanel;
    // Start is called before the first frame update
    void Start()
    {
        pauseButton.onClick.AddListener(pause);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void pause()
    {
        resumePanel.SetActive(true);
        Time.timeScale = 0;
    }
}
