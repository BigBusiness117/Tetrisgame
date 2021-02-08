using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawn : MonoBehaviour
{
    public GameObject spawn;
    Vector3 move; 
    private GameObject Block;
    public float speed = -1; 
    private Rigidbody rb;
    private float downWardSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        Block = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Block.transform.position = spawn.transform.position;
        Block.GetComponent<Renderer>().material.color = Color.red;
        Block.AddComponent<Rigidbody>();
        rb = Block.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.useGravity = false;
        Block.AddComponent<BoxCollider>();
        Block.AddComponent<BlockCollisionDetector>();
    }

    // Update is called once per frame
    void Update()
    {
        
        move = new Vector3(0, speed, 0);
        Block.transform.Translate(move * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.A))
        {
            Block.transform.Translate(-downWardSpeed, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Block.transform.Translate(downWardSpeed, 0, 0);

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Block.transform.Translate(0, -downWardSpeed, 0);

        }

    }

}
