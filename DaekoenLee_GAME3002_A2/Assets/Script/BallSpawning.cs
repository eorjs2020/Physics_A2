using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawning : MonoBehaviour
{
    public GameObject ball;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        

        if(EventSystem.ballIsDead && EventSystem.lifeValue > 0)
        {
            --EventSystem.lifeValue;
            SpawnBall();
            EventSystem.ballIsDead = false;
        }
    }

    public void SpawnBall()
    {        
        Instantiate(ball, gameObject.transform.position, Quaternion.identity);
    }
}
