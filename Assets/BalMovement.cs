using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalMovement : MonoBehaviour
{

    public UDPReceive receiveData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string data = receiveData.data; //store data received from UDP receive
        data = data.Remove(0, 1); //remove opening bracket
        data = data.Remove(data.Length - 1, 1); // remove closing bracket
        string[] info = data.Split(','); // split data based on comma

        float x = 5 -float.Parse(info[0])/100; // divide the value because in unity the objs move in relatively close fraction. the value we receive from python is much bigger so we should normalize it;
        float y = float.Parse(info[1])/100;
        float z = -3 + float.Parse(info[2])/1000;

        gameObject.transform.localPosition = new Vector3(x, y, z); 
    }
}
