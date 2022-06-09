using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    public Transform player;
    Transform cannon;
    float distanceBetwwenPlayer;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        cannon = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceBetwwenPlayer = Vector3.Distance(player.position, cannon.position);
        if (distanceBetwwenPlayer <= 20)
            BallSpawner();
    }

    void BallSpawner()
    {
      
        Instantiate(ball, cannon.position,Quaternion.identity);
        Destroy(gameObject);
    }
}
