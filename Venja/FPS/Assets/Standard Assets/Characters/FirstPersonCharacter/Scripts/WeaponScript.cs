using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponScript : MonoBehaviour
{
    public GameObject bullet;
    public Transform muzzle;
    public int CurAmmo;
    public int maxAmmo;
    public bool infAmmo;
    public float shootRate;
    private float lastShootTime;
    public bool isPlayer;
    public AudioSource firesound;

    private void Awake()
    {
        if (GetComponent<FirstPersonController>())
        {
            isPlayer = true;
        }

        //firesound = GetComponent<AudioSource>();
    }
    public bool CanShoot()
    {
       if (Time.time-lastShootTime >= shootRate)
        {
            if(CurAmmo>0 || infAmmo == true)
            {
                return true;
            }
        }
        return false;
    }

    public void Shoot()
    {
        lastShootTime = Time.time;
        CurAmmo--;
        GameObject pulja = Instantiate(bullet, muzzle.position, muzzle.rotation);
        pulja.GetComponent<Rigidbody>().velocity = muzzle.forward * 50;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
