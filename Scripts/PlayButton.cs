using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayButton : MonoBehaviour
{

    public Button playButton;
    public GameObject menuPanel;
    // Start is called before the first frame update
    void Start()
    {
        
        Time.timeScale = 0;
        playButton.onClick.AddListener(Play);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Play()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
