using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Player : MonoBehaviour
{

    public Rigidbody2D rb;
    public TMP_Text powersText,scoreText;
    public int powerCount=0,scoreCount=0;
    public GameObject laser,laserPosition,enemy1,enemy2,heart;
    private GameObject[] enemeyPosition;
    public float velocity = 10;
    int randomEnemyPosition;
    public Colider coliderClass;

    // Start is called before the first frame update
    void Start()
    {
        GameObject thePlayer = GameObject.Find("colider");
        coliderClass = thePlayer.GetComponent<Colider>();

        enemeyPosition = GameObject.FindGameObjectsWithTag("enemyStart");
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("creatEnemy1", 1f, 3f);
        InvokeRepeating("creatEnemy2", 2f, 2f);
        InvokeRepeating("creatHealth", 5f, 8f);
    }

    // Update is called once per frame
    void Update()
    {

         randomEnemyPosition = Random.Range(0, enemeyPosition.Length);
        fly();
        fire();
        if (powerCount == 5)
        {
            coliderClass.health += 1;
            powerCount = 0;
        }
        powersText.text = "POWERS:0" + powerCount;
        scoreText.text = "SCORE:" + scoreCount;


    }

    void fly()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity=Vector2.up *velocity;
        }
    }

    void fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(laser, laserPosition.transform.position, Quaternion.identity);
        }
        
    }

    void creatEnemy1()
    {
        Instantiate(enemy1, enemeyPosition[randomEnemyPosition].transform.position, Quaternion.identity);
    }
    void creatEnemy2()
    {
        Instantiate(enemy2, enemeyPosition[randomEnemyPosition].transform.position, Quaternion.identity);
    }

    void creatHealth()
    {
        Instantiate(heart, enemeyPosition[randomEnemyPosition].transform.position, Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "heart")
        {
            powerCount++;
            powersText.text = "POWERS:0" + powerCount;
            Destroy(collision.gameObject);

        }
    }
    public void IncreaseScoreByLaserClass()
    {
        scoreCount++;
    }
    
}
