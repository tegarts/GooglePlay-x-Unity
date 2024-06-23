using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Section11 : MonoBehaviour
{
    public int speed = 5;
    Vector3 initialPos = new Vector3(0, 2, 0);

    // Variable Types
    int dataTypeInt = 5;
    float dataTypeFloat = 5.5f;
    bool dataTypeBool = true;
    string dataTypeString = "Hello World";
    Vector3 dataTypeVector3 = new Vector3(1, 2, 3);

    private void Start() 
    {
        transform.position = initialPos;
        transform.rotation = Quaternion.Euler(0, 90, 0);

        // Variable Types
        dataTypeVector3.x =+ 50f;
        Debug.Log(dataTypeString);
        if(dataTypeBool)
        {
            dataTypeInt = 10;
            dataTypeFloat = 5.1f;
        }
    }

    private void Update() 
    {
        
    }

}
