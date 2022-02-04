using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = ZInput.GetAxis("X");
        float y = ZInput.GetAxis("Y");
        transform.Translate(new Vector3(x, y , 0) * 5 * Time.deltaTime);
        //-------------------------------------------------------------
        if(ZInput.GetKeyDown("button1"))
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        }
    }
}
