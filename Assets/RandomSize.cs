using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSize : MonoBehaviour
{

    Transform trans;
    // Start is called before the first frame update
    void Start()
    {
        trans = GetComponent<Transform>();
        trans.localScale += new Vector3(Random.Range(-6,6), Random.Range(-20, 5), Random.Range(-6, 6));
    }

}
