using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private GameObject knifeObject;

    [SerializeField]
    private Transform shotPoint;

    [SerializeField]
    private float timeInSec = 5f;

    [SerializeField]
    private float holdStartTime;


    bool isHoldingfireButton;
   

    private void Start()
    {
        
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            isHoldingfireButton = true;
            holdStartTime = Time.time;

            StartCoroutine(startTimerforHolding());

        } 


        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            
                // Reset the flag and stop the timer coroutine
                isHoldingFireButton = false;
                StopCoroutine(StartTimerForHolding());

                // Calculate the bullet force based on the time the button was held
                float holdTime = Mathf.Clamp(Time.time - holdStartTime, 0f, maxTimeInSec);
                float bulletForce = holdTime / maxTimeInSec;

                Debug.Log("Mouse Released. Hold Time: " + holdTime + "s. Bullet Force: " + bulletForce);

                // Spawn the knife with the calculated force
                KnifeSpawn(bulletForce);

            
        }

    }

    void knifeSpwan()
    {
       // Instantiate the Knife with the calculated bullet force
        Instantiate(knifeObject, shotPoint.position, Quaternion.identity);      
    }
    IEnumerator startTimerforHolding()
    {    
       
        yield return null; 
        
     }
         
}
