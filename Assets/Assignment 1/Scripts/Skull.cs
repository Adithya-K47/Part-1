using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertdirection = Input.GetAxis("Vertical");
        transform.Translate(0, vertdirection * speed * Time.deltaTime, 0);

        float hordirection = Input.GetAxis("Horizontal");
        transform.Translate(hordirection * speed * Time.deltaTime, 0, 0);

    }
}
