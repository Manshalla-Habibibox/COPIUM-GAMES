using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    Vector3 moveleft;
    Vector3 moveright;
    int x = 0;
    float y = .1f;
    // Start is called before the first frame update
    void Start()
    {
        moveleft = new Vector3(.1f, 0, 0);
        moveright = new Vector3(-.1f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 42)
        {
            x = 1;

        }else if (transform.position.x < -86)
        {
            x = 0;
        }
        if (x == 0)
        {
            transform.Translate(moveright);
        }
        else
        {
            transform.Translate(moveleft);
        }
    }
}
