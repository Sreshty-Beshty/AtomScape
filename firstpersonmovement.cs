using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstpersonmovement : MonoBehaviour
{
    public float ypos;
    public Vector3 positionadd = new Vector3();
    public float speed;
    public Vector3 position = new Vector3();
    public GameObject camera;
    public bool movementenabled = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movementenabled)
        {
            if (Input.GetKey(KeyCode.W))
            {
                positionadd = transform.forward * speed * Time.deltaTime;
                ypos = transform.position.y;
                position = transform.position + positionadd;
                transform.position = new Vector3(position.x, ypos, position.z);
            }
            if (Input.GetKey(KeyCode.S))
            {
                positionadd = -transform.forward * speed * Time.deltaTime;
                ypos = transform.position.y;
                position = transform.position + positionadd;
                transform.position = new Vector3(position.x, ypos, position.z);
            }
            if (Input.GetKey(KeyCode.A))
            {
                positionadd = -transform.right * speed * Time.deltaTime;
                ypos = transform.position.y;
                position = transform.position + positionadd;
                transform.position = new Vector3(position.x, ypos, position.z);
            }
            if (Input.GetKey(KeyCode.D))
            {
                positionadd = transform.right * speed * Time.deltaTime;
                ypos = transform.position.y;
                position = transform.position + positionadd;
                transform.position = new Vector3(position.x, ypos, position.z);
            }

        }
    }
}
