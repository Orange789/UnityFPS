using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public Slider myHealth;

    // Start is called before the first frame update
    void Start()
    {
        myHealth.value = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseHealth()
    {
        health--;
        myHealth.value--;
        if(health<= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
