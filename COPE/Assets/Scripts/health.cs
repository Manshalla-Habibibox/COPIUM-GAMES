using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public Text Health;
   
    // Start is called before the first frame update
    void Start()
    {
        Health.text = "health:" + PlayerStats.health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
