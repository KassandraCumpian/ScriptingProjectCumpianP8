using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualAxis : MonoBehaviour
{
    public float hRange;
    public float zRange;
    private float z;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float zPos = z * zRange;


        transform.position = new Vector3(xPos, 0, zPos);

    }
}
