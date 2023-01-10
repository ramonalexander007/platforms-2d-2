using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_taker : MonoBehaviour
{


    public int damage;
    public bool ignoreInvencible;
    public string target = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag==target)
        {
            collision.GetComponent<Life_controller>().Damage(damage, ignoreInvencible);
        }
    }
}
