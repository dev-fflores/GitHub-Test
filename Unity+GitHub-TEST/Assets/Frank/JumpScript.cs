using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    Transform _transform;

    void Start()
    {
        _transform = GetComponent<Transform>();    
    }

    // Update is called once per frame
    void Update()
    {
        //Finish
        _transform.position += new Vector3(0f, 0f, 0.02f);
    }
}
