using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    private Rigidbody rigb;
    private SceneM flag;
    public CapsuleCollider playerCollider;


    void Start()
    {
        //playerCollider = this.GetComponent<CapsuleCollider>();
        rigb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-moveVert, 0.0f, moveHoriz);
        rigb.AddForce(movement * speed);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag == "Flag")
    //    {
    //        //flag = collision.gameObject.GetComponent<EndGameFlag>();
    //    }
    //}

}

