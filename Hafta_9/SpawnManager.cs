using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemy;
    public GameObject tripleShotBonus;
    public GameObject speedBonus;

    public bool enemySpawnerWorking;
    public bool tripleShotSpawnerWorking;
    public bool speedSpawnerWorking;

    public bool isGameStarted;
    public bool isWorking;

    private void Update()
    {
        if (!isWorking)
        {
            Spawner();
        }
    }



    public void Spawner()
    {
        if (isGameStarted)
        {
            enemySpawnerWorking = true;
            tripleShotSpawnerWorking = true;

            StartCoroutine(EnemySpawner());
            StartCoroutine(TripleShotSpawner());
            StartCoroutine(SpeedBonusSpawner());

            isWorking = true;
        }
    }



    IEnumerator EnemySpawner()
    {
        Transform parentObj = GameObject.FindWithTag("EnemyParent").transform;

        while (enemySpawnerWorking)
        {
            Instantiate(enemy, new Vector3(Random.Range(-8.5f, 8.5f), 6.5f, 0), Quaternion.identity, parentObj);
            yield return new WaitForSeconds(5);
        }

    }

    IEnumerator TripleShotSpawner()
    {
        while (tripleShotSpawnerWorking)
        {
            Instantiate(tripleShotBonus, new Vector3(Random.Range(-8.5f, 8.5f), 6.5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(10);
        }

    }

    IEnumerator SpeedBonusSpawner()
    {
        while (tripleShotSpawnerWorking)
        {
            Instantiate(speedBonus, new Vector3(Random.Range(-8.5f, 8.5f), 6.5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(10);
        }
    }

    public void StopEnemySpawner()
    {
        enemySpawnerWorking = false;
    }

    public void StopTripleShotSpawner()
    {
        tripleShotSpawnerWorking = false;
    }
    
    public void StopSpeedSpawner()
    {
        speedSpawnerWorking = false;
    }

}
