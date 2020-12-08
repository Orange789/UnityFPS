using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finish : MonoBehaviour
{
    public Transform player;
    public Transform target;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            Application.LoadLevel(1);
        }
    }



    private float Distance()
    {
        return Vector3.Distance(player.position, target.position);
    }

    private void Start()
    {
        GameObject.Find("dist").GetComponent<Text>().text = Distance().ToString();
    }
    private void Update()
    {
        GameObject.Find("dist").GetComponent<Text>().text = Distance().ToString();
    }
} 