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
    public Transform SideShooterLeft;
    public Transform SideShooterRight;

    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        //looks for the Fire1 button pre-assigned by Unity
        if (Input.GetButtonDown("Fire1"))
        {
            //calls method Shoot() when player clicks
            Shoot();
        }
    }

    void Shoot()
    {
        // shooting logic
       Instantiate(bulletPrefab, SideShooterLeft.position, SideShooterLeft.rotation);

        Instantiate(bulletPrefab, centerShooter.position, centerShooter.rotation);

       Instantiate(bulletPrefab, SideShooterRight.position, SideShooterRight.rotation);
    }
}
