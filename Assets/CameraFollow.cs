using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Rigidbody rb;

    [Range(0,1)]public float dampener;
    public Transform curTarget;
    public Transform target;
    public Transform target2;
    public Transform lookAtTarget;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    bool thirdPerson;

    private void Start()
    {
        curTarget = target;
        rb = target.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            if (curTarget != target)
            {
                transform.eulerAngles = new Vector3(85, 0, 0);
                offset = new Vector3(0, 33, 2);
                curTarget = target;
                thirdPerson = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                offset = new Vector3(0, 2, -3);
                curTarget = lookAtTarget;
                thirdPerson = true;
            }
        }
    }

    public void switchTarget(Transform cameraTarget)
    {
        

    }

    private void LateUpdate()
    {
        Vector3 desiredPostion = transform.position = target.position + offset + (rb.velocity * dampener);
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPostion, smoothSpeed);
        transform.position = smoothPosition - transform.forward;

        //transform.eulerAngles = Quaternion.LookRotation(smoothPosition);

        transform.LookAt(smoothPosition);
    }

}
