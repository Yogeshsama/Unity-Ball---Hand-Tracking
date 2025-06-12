using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTracking : MonoBehaviour
{

    public UDPReceive receiveDate;
    public GameObject[] handPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string data = receiveDate.data;
        data = data.Remove(0, 1);
        data = data.Remove(data.Length- 1 , 1);
        string[]  points = data.Split(',');
        print(points[0]);

        for (int i = 0; i < 21; i++)
        {                                                                                                                             //0          1*3        2*3
            float x = 3-float.Parse(points[i*3])/100; //iterating by multiplying by three so it gives us x value only. For eg the values are: x1, y1, z1, x2, y2, z2, x3, y3, z3
            float y = float.Parse(points[i * 3 + 1]) / 100;
            float z = float.Parse(points[i * 3 + 2]) / 100;

            handPoints[i].transform.localPosition = new Vector3(x, y, z); 
        }

    }
}
