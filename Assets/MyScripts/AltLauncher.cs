using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltLauncher : MonoBehaviour
{
    public GameObject projectile;
    public GameObject projectileSpawnPoint;
    public bool canShoot = true;
    public float timeBetweenShoots;
    public AudioSource audioSource;
    public AudioClip arrowFiringSound;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Shoot()
    {
        if(canShoot == true)
        {
            StartCoroutine(BetterShoot());
        }
    }
    IEnumerator BetterShoot()
    {
        if(canShoot == true)
        {
            Instantiate(projectile, projectileSpawnPoint.transform.position, projectileSpawnPoint.transform.rotation);
            audioSource.PlayOneShot(arrowFiringSound);
            canShoot = false;
        }
        yield return new WaitForSeconds(timeBetweenShoots);
        canShoot = true;
    }
  
}
