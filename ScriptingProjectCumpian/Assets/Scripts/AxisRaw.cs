using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisRaw : MonoBehaviour
{
    public float range;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float xPoss = h * range;


        transform.position = new Vector3(xPoss, 2f, 0);
        Debug.Log("VValue Returned: " + h.ToString("F2"));
    }
}
