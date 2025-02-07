using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonNewTrainingDummies : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemyCount;
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnPoint3;
    public GameObject spawnPoint4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<TrainingDummyControl>().Length;

    }
    public void SummonNewWave()
    {
        if (enemyCount == 0)
        {
            Instantiate(enemyPrefab, spawnPoint1.transform.position, spawnPoint1.transform.rotation);
            Instantiate(enemyPrefab, spawnPoint2.transform.position, spawnPoint2.transform.rotation);
            Instantiate(enemyPrefab, spawnPoint3.transform.position, spawnPoint3.transform.rotation);
            Instantiate(enemyPrefab, spawnPoint4.transform.position, spawnPoint4.transform.rotation);
        }
    }    
}
