using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockmove : MonoBehaviour
{
    float annoying_spped;
    // Start is called before the first frame update
    void Start()
    {
        annoying_spped = -0.03f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= 5f)
        {
            annoying_spped = -0.03f;
        }
        if (transform.position.z <= -5f)
        {
            annoying_spped = +0.03f;
        }
        


        transform.position += new Vector3(0, 0, annoying_spped);
    }
}
