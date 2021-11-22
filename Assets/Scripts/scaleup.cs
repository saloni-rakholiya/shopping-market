using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      transform.localScale = new Vector3(Mathf.PingPong(Time.time, 3), transform.localScale.y, transform.localScale.z);
    }
}
