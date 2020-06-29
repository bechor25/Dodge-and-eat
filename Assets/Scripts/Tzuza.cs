using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tzuza : MonoBehaviour
{
    Vector3 mikum; //  2:3 -- object of class Vector3
    float tsaad = 7.0f; // 2:5 -- size of offset. In fact: speed....
    float gvulMasach = 4.0f; //
                            // 2:10
                            //    public float tsaad = 4.0f; // 2:5 -- size of offset. In fact: speed....
                            //   public float gvulMasach = 11; //

    void Start()
    {

    }

    void Update()
    {
        mikum = transform.position; // 2:4 -- gets on each update the xyz of "Ets"
        //mikum.x += tsaad;           // 2:6 -- new X value
        mikum.x += tsaad * Time.deltaTime; // 2:8 -- to compensate time for each comp
        transform.position = mikum; // 2:7 -- set the position to new value


        // 2:9
        if ((mikum.x > gvulMasach) || (mikum.x < -gvulMasach)) { tsaad *= -1; }
    }
}
