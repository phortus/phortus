using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colectiblecontroller : MonoBehaviour
{
    public amount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OntriggerEnter2D(collider collision)
    {
        if (collision.tag == "player")
        {
            collision.GetComponente<Player>().changeHealth(amount);
            if(gameObject.tag != "Spikes")
           {
                Destroy(gameObject);
            }
        }
    }
}
