using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureRecog : MonoBehaviour
{

    public UDPReceive UDPReceive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string gesture = UDPReceive.data;
        print(gesture);
    }
}
