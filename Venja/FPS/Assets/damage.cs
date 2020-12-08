using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            collision.gameObject.SendMessage("TakeDamage");
        }
        if (collision.gameObject.tag == "npc")
        {
            collision.gameObject.SendMessage("TakeDamage");
        }
    }

}
