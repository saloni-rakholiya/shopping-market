using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_1 : MonoBehaviour
{
    Vector3 Vec;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
              transform.Rotate (0,0,100*Time.deltaTime);
    }
}
