using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QyitButton : MonoBehaviour
{

    public Button   quitButton;
    // Start is called before the first frame update
    void Start()
    {
        quitButton.onClick.AddListener(Exit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Exit()
    {
        Application.Quit();
    }
}
