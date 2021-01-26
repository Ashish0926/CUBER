using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camScript : MonoBehaviour
{
    public Transform position;
    public Vector3 offset;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = position.position + offset;
    }
}
