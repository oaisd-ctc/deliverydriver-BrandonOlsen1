using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
     [SerializeField]float steerspeed = 10f;
     [SerializeField]float moveSpeed = 10f;
      [SerializeField] float slowspeed = 15f;
     [SerializeField] float boostspeed = 30f;

    

    
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerspeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
        
    }

       void OnTriggerEnter2D(Collider2D other) {
        if (tag == "Boost")
        {
            moveSpeed = boostspeed;
        }
       }

        void OnCollisionEnter2D(Collider2D other)
        {
                moveSpeed = slowspeed;
            
        }
    



}
