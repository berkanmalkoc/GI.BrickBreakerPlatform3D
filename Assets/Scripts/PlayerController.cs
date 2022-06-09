using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;

    float speed = 10;
    float forwardSpeed = 5;
    float yatayoktusu;
    bool moving=true;



    private void FixedUpdate()
    {
        if(moving)
        oyuncu_hareketi();
    }

    void oyuncu_hareketi()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*forwardSpeed);
        yatayoktusu = Input.GetAxis("Horizontal");
        rb.velocity = (Vector3.right * speed) * yatayoktusu;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ScaleUp()
    {
        transform.localScale = new Vector3(transform.localScale.x + 1, transform.localScale.y, transform.localScale.z);
    }

    void ScaleDown()
    {
        transform.localScale = new Vector3(transform.localScale.x - 1, transform.localScale.y, transform.localScale.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Brick")
        {
            ScaleDown();
            Destroy(collision.gameObject);
        }

     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ScaleUp")
        {
            Destroy(other.gameObject);
            ScaleUp();
        }

        if(other.gameObject.tag== "Finish")
        {
            FinishMove();

        }
    }


    public void FinishMove()
    {
        moving = false;
        transform.DOMoveX(0, 2);
        transform.DOMoveZ(660, 8);

    }
}
