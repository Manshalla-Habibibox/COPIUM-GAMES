using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int health = 100;
    public GameObject destroyPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collison)
    {
        if(collison.gameObject.tag == "Enemy1")
        {
            health -= 101;

            if (health <= 0)
            {
                Die();
            }
        }
    }
    private void Die()
    {
        Destroy(destroyPlayer);
    }
}
