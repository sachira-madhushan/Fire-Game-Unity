using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour
{
    public Button resumeButton;
    public GameObject resumePanel;

    void Start()
    {
        resumeButton.onClick.AddListener(resume);
    }



    void Update()
    {
        
    }
    void resume()
    {
        resumePanel.SetActive(false);
        Time.timeScale = 1;
    }
}
