using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crabmovement : MonoBehaviour
{
    public float xmovement=1f;
    bool right = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.GetComponent<Rigidbody2D>().velocity = new Vector3(xmovement*Time.deltaTime,0f,0f);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("here");
        //Debug.Log(transform.localScale);
        if (transform.localScale.x>0)
        {
            
            
            transform.localScale = new Vector3(-1f,1f,1f);
            crabmove();
        }
       else if (transform.localScale.x < 0)
        {
           
  
            transform.localScale = new Vector3(1f, 1f, 1f);
            crabmove();
        }
    }

    public void crabmove()
    {
        
    xmovement = -xmovement;
        
        
    }
}
