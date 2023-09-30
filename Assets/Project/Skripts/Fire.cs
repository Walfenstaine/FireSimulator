using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float helse = 10;
    private Transform player;

    void Start()
    {
        player = Muwer.rid.transform; 
    }

 
    void Update()
    {
        Vector3 look = new Vector3(player.position.x, 0, player.position.z);
        transform.LookAt(look);
        if (helse > 0)
        {
            float scal = helse / 4;
            transform.localScale = new Vector3(scal, scal, scal);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
