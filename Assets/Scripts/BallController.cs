using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody top_rigi;
    public GameObject playerTransform;
    

    float hiz = 10;
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("Player");
        
        
     
        baslangic_vurusu();
    }
    private void Update()
    {
        if(transform.position.z<= playerTransform.transform.position.z - 5)
        {
            Destroy(gameObject);
        }
    }

    void baslangic_vurusu()
    {
        top_rigi.velocity = Vector3.zero;
        
        top_rigi.velocity = new Vector3(hiz, 0, -hiz);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Brick")
        {
            Destroy(collision.gameObject);
            GameManager.Instance.ScoreUp(1);
          
       
        }

        if (collision.gameObject.name == "solduvar")
        {
            top_rigi.velocity = new Vector3(hiz, 0, top_rigi.velocity.z);
        }

        if (collision.gameObject.name == "sagduvar")
        {
            top_rigi.velocity = new Vector3(-hiz, 0, top_rigi.velocity.z);
        }

        if (collision.gameObject.name == "Player")
        {
            top_rigi.velocity = new Vector3(top_rigi.velocity.x, 0, hiz);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
            GameManager.Instance.ScoreUp(10);
        }
    }

}
