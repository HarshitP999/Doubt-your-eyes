using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPhysics : MonoBehaviour
{
    Rigidbody2D rb;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
    }
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.gameObject);

        }
    }

    public void static knifeForce(float knifePower)
    {
        rb.AddForce(transform.forward * knifePower, ForceMode2D.Impulse);
    }




    void knifeLife()
    {
        Destroy(gameObject , 2);
    }
    
}
