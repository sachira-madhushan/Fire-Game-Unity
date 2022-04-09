using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Laser : MonoBehaviour
{

    public float speed = 2;
    public GameObject player;
    public TMP_Text scoreText;
    public int score = 0;
    public Player playerClass;

    void Start()
    {
         player = GameObject.Find("Player");
        playerClass = player.GetComponent<Player>();
    }


    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;

        float x = Vector2.Distance(player.transform.position, transform.position);

        if (x > 10f)
        {
            Destroy(this.gameObject);
        }
        scoreText.text = "SCORE:" + score;


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy" )
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            score++;
            playerClass.IncreaseScoreByLaserClass();
        }
        if(collision.gameObject.tag == "heart")
        {
            Destroy(this.gameObject);
        }

    }
}
