using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
      rb.AddForce(transform.up*speed);
        Object.Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
