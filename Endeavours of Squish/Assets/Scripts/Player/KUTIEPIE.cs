using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 1/11/2019 CJA
 * Weapon Class for three shooting points
 */
public class KUTIEPIE : MonoBehaviour
{
    //points to transform
    public Transform centerShooter;
    public Transform PowerShot;

    public GameObject powerShotPrefab;
    public GameObject bulletPrefab;

    public float shotDelay = 0.25f;
    public float cooldownTimer1 = 0;
    //bigger difference one for HUD
    public float powerDelay = 0;
    
    [SerializeField]
    private Stat power;
    private void Awake()
    {
        power.Initialize();
    }
    // Update is called once per frame
    void Update()
    {
        cooldownTimer1 -= Time.deltaTime;
        //looks for the Fire1 button pre-assigned by Unity
        if (Input.GetButtonDown("Fire1") && cooldownTimer1 <= 0) 
        {
            //calls method Shoot() when player clicks
            Shoot();
            cooldownTimer1 = shotDelay;
        }
        power.CurrentVal += Time.deltaTime;
       
        if (Input.GetButtonDown("Fire2") && power.CurrentVal == 10)
        {
            PowerShoot();
            power.CurrentVal = powerDelay;
            
        }
        
    }
    
void Shoot()
    {
        // shooting logic
        Instantiate(bulletPrefab, centerShooter.position, centerShooter.rotation);
    }
    void PowerShoot()
    {
        Instantiate(powerShotPrefab, PowerShot.position, PowerShot.rotation);
    }
}
