using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameramanbenidecek : MonoBehaviour
{
    Vector3 fark;
    public Transform top;

    [Range(0.01f, 1.0f)]
    public float smoothfactor = 0.5f;
    public bool lookatplayer = false;
    public bool rotatearoundplayer = true;
    public float rotationsspeed = 5.0f;
    void Start()
    {
        fark = transform.position - top.position;
    }

    void LateUpdate()
    {

        if(rotatearoundplayer)
        {
            Quaternion camturnangle = 
                Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationsspeed, Vector3.down);

            fark = camturnangle * fark;
        }

        Vector3 newPos = top.position + fark;

        transform.position = Vector3.Slerp(transform.position, newPos, smoothfactor);  //transform.position = fark + top.transform.position;



        if (lookatplayer || rotatearoundplayer)
        {
            transform.LookAt(top);
        }
    }
}
