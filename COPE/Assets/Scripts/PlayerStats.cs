using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int health = 1;
    public GameObject destroyPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Die();
        }
    }
    void OnCollisionEnter(Collision collison)
    {
        if (collison.gameObject.tag == "Enemy1")
        {
            health = health - 100000;
            Debug.Log("hit");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy1")
        {
            health = 10000000;
            Debug.Log("hit");
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
