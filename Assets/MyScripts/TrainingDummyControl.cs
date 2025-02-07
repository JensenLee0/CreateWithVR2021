using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingDummyControl : MonoBehaviour
{
    public AudioSource TDAudio;
    public AudioClip hurtSound;
    public int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        TDAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Weapon"))
        {
            health = health - 1;
            TDAudio.PlayOneShot(hurtSound);
            if(health == 0)
            {
                Destroy(gameObject, 0.5f);
            }
        }
    }
}
