using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class userInterface : MonoBehaviour
{
    public Text keys;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        keys.text = "keys:" + PlayerStats.keys;
    }
}
