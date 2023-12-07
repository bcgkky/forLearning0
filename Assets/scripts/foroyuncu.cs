using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foroyuncu : MonoBehaviour
{
    Rigidbody fz;
    public float hiz;
    void Start()
    {
        fz = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 vk = new Vector3(yatay, 0, dikey);

        fz.AddForce(vk*hiz);
    }
}
