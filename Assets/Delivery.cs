using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] float destroyDelay = 0.5f;

   


    






    bool hasPackage = false;

    SpriteRenderer spriteRenderer;

     void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }




    void OnCollisionEnter2D(Collision2D other) {
    Debug.Log("YOU CRASHED");
   }
    void OnTriggerEnter2D(Collider2D other)
     {
    if(other.tag == "Package" && !hasPackage)
       {
        hasPackage = true;
        Destroy(other.gameObject, destroyDelay);
        spriteRenderer.color = hasPackageColor;
        Debug.Log("Package secured");
    }

    if (other.tag == "Customer" && hasPackage)
    {
        Debug.Log("PACKAGE RECIEVED!");
        hasPackage = false;
        spriteRenderer.color = noPackageColor;
    }
   }

    




}
