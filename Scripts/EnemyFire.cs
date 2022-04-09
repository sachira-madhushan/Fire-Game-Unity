using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public float speed = 100;
    public GameObject firePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        float x = Vector2.Distance(firePosition.transform.position, transform.position);

        if (x > 10f)
        {
            Destroy(this.gameObject);
        }
    }
    
}
