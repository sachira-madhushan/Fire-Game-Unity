using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Colider : MonoBehaviour
{

    public TMP_Text healthText;
    public GameObject gameOverPanel;
    public int health = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
        healthText.text = "LIFE:0" + health;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy"  )
        {
            Destroy(collision.gameObject);
            health--;
            healthText.text = "LIFE:0" + health;
        }
        if(collision.gameObject.tag == "heart")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void increaseHealthByClassPlayer()
    {
        health++;
    }
}
