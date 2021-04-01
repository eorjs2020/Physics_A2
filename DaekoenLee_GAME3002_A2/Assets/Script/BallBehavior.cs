using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    Rigidbody rigid;
    Vector3 vel;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (gameObject.transform.position.y < -8.0f)
        {
            EventSystem.ballIsDead = true;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        vel = rigid.velocity;
    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.layer == 11)
        {
            ContactPoint cp = c.contacts[0];
           
            // calculate with Vector3.Reflect
            rigid.velocity = Vector3.Reflect(vel, cp.normal);

            // bumper effect to speed up ball
            rigid.velocity += cp.normal * 2.0f;

            EventSystem.scoreValue += 100;
        }
        if (c.gameObject.layer == 12)
        {
            EventSystem.scoreValue += 100;
        }
        if (c.gameObject.layer == 13)
        {
            EventSystem.scoreValue += 1000;
        }
    }

}
