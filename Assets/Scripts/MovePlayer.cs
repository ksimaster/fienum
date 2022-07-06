using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject field;
    public float speed = 10f;

    void Start()
    {
        gameObject.transform.position = new Vector3(0,1,0);
    }

    
    void FixedUpdate()
    {
        EasyMove();
    }

    public void EasyMove()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(0, 0, 10), speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(10, 0, 0), speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(0, 0, -10), speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(-10, 0, 0), speed * Time.deltaTime);
    }

    public void MoveToCenterPlane(GameObject plane)
    {
        var target = transform.position + plane.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

}
