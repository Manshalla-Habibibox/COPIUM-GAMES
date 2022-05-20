using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int health = 100;
    public GameObject destroyPlayer;
    public static int keys = 0;
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
        if (collison.gameObject.tag == ("Enemy1"))
        {
            Debug.Log(health);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy1")
        {
            health =health - 10;
            Debug.Log(health);
        }
        if (health <= 0)
        {
            Die();
        }
        if (other.gameObject.tag == "Collectable")
        {
            Destroy(other.gameObject);
            keys++;
            Debug.Log("Key");
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }

}
