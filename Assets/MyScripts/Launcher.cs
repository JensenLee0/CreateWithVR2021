using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject projectile;
    public GameObject projectileSpawnPoint;
    public bool isShooting;
    public float timeBetweenShoots;

    //public TVCanvasControl tvControl;

    public void StartShooting()
    {
        //Instantiate(projectile, projectileSpawnPoint.transform.position, projectileSpawnPoint.transform.rotation);
        isShooting = true;
        StartCoroutine(BetterShoot());
    }
    IEnumerator BetterShoot()
    {
        Instantiate(projectile, projectileSpawnPoint.transform.position, projectileSpawnPoint.transform.rotation);
        //tvControl.AddToScore();
        yield return new WaitForSeconds(timeBetweenShoots);
        if (isShooting == true)
        {
            StartCoroutine(BetterShoot());
        }
    }
    public void StopShooting()
    {
        isShooting = false;
    }
}
