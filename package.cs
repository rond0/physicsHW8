using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class package : MonoBehaviour
{
    [SerializeField] HingeJoint2D HJ;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float torque;
    [SerializeField] Animator anim;
    [SerializeField] Collider2D col;
   
    // Start is called before the first frame update
    void Start()
    {
   
        
    }

    // Update is called once per frame
    void Update()
    {
       
    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        anim.enabled = false;
    }
}
