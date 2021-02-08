using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mnrty : MonoBehaviour
{
    Vector3 move;
    private GameObject Block;
    public float speed = -1;
    private Rigidbody rb;
    private float downWardSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        move = new Vector3(0, speed, 0);
        gameObject.transform.Translate(move * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.Translate(-downWardSpeed, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.Translate(downWardSpeed, 0, 0);

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.Translate(0, -downWardSpeed, 0);

        }

    }
    void OnCollisionEnter(Collision collision)
    {

        move *= -1;
        Debug.Log("hi");

    }
}
