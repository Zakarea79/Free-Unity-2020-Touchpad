using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Touch_3D : MonoBehaviour
{
    void Start()
    {
        ZInput.EnableWarning = false;
    }
    void Update()
    {
        float x = ZInput.GetAxis("X");
        float y = ZInput.GetAxis("Y");
        transform.position += new Vector3(x, 0, y) * 5 * Time.deltaTime;
        //-------------------------------------------------------------
        if (ZInput.GetKeyDown("button1"))
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        }
        if (ZInput.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        }
        transform.rotation = ZInput.Get_3D_Direction("3D_Dir");
    }
}
