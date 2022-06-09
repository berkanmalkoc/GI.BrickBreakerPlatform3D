using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBalls : MonoBehaviour
{
    Rigidbody top_rigi;
    // Start is called before the first frame update
    void Start()
    {
        top_rigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
            GameManager.Instance.ScoreUp(10);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
      

       


        if (collision.gameObject.name == "Player")
        {
            top_rigi.velocity = new Vector3(top_rigi.velocity.x, 0, 7);
        }


    }
}
