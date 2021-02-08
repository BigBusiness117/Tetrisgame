using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawn : MonoBehaviour
{
    public GameObject spawn;
    Vector3 move = new Vector3(0, -1, 0);
    private GameObject Block;
    private Rigidbody rb;
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
    }

    // Update is called once per frame
    void Update()
    {
        Block.transform.Translate(move * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.A))
        {
            Block.transform.Translate(-1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Block.transform.Translate(1, 0, 0);

        }

    }
}
