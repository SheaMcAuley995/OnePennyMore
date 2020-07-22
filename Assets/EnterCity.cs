using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class EnterCity : MonoBehaviour
{

    public UnityEvent m_MyEventEnter;
    public UnityEvent m_MyEventExit;
    public LayerMask playerLayer;

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            m_MyEventEnter.Invoke();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            m_MyEventExit.Invoke();
        }
    }
}
