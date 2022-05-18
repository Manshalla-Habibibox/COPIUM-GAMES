using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    Vector3 moveleft;
    Vector3 moveright;
    // Start is called before the first frame update
    void Start()
    {
        moveleft = new Vector3(1, 0, 0);
        moveright = new Vector3(-1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 42)
        {
            transform.Translate(moveright);
        }else if (transform.position.x < -86)
        {
            transform.Translate(moveleft);
        }
    }
}
