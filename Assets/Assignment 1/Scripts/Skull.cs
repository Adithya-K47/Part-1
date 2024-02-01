using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rigidbody;
    public float forwardForce = 6f;
    public Transform forcePos;
    // Start is called before the first frame update
    void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();    
    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertdirection = Input.GetAxis("Vertical");
        transform.Translate(0, vertdirection * speed * Time.deltaTime, 0);

        float hordirection = Input.GetAxis("Horizontal");
        transform.Translate(hordirection * speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 forceDirection = transform.forward;
            rigidbody.AddForceAtPosition(forwardForce * forceDirection, forcePos.position);
            }


    }
}
