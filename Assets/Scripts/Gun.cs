using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;

    public Transform cannonEnd;

    private void Update()
    {
         if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;

       if(Physics.Raycast(cannonEnd.position, cannonEnd.right, out hit))
        {
            Debug.Log(hit.transform.name);
            Debug.DrawLine(cannonEnd.position, hit.transform.position);
        }
            

        
    }
}
