using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlungeController : MonoBehaviour
{
    public Rigidbody rigid;
    private Vector3 oriPosition;
    private float speed = 0.5f;
    private bool isTriggered;
    private bool switched;
    // Start is called before the first frame update
    void Start()
    {
        switched = false;
        isTriggered = false;
        oriPosition = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if(isTriggered)
        {
            float step = speed * Time.deltaTime;
            GetComponent<Transform>().position = Vector3.MoveTowards(GetComponent<Transform>().position, oriPosition, step);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switched = false;
            isTriggered = true;
            rigid.isKinematic = true;
            
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            switched = true;
            isTriggered = false;
            rigid.isKinematic = false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.layer == 8 && !switched)
        {
            rigid.isKinematic = true;
        }
    }
}
