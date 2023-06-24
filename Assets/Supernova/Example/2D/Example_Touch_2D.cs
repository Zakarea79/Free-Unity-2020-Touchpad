using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Touch_2D : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float x = ZInput.GetAxis("X");
        float y = ZInput.GetAxis("Y");
        transform.position += new Vector3(x, y, 0) * 5 * Time.deltaTime;
        //-------------------------------------------------------------
        if (ZInput.GetKeyDown("button1"))
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        }
        if (ZInput.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        }
        transform.rotation = ZInput.Get_2D_Direction("2D_Dir");
    }
}
