using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemy;
    public GameObject tripleShotBonus;

    public bool enemySpawnerWorking;
    public bool bonusSpawnerWorking;

    private void Start()
    {
        enemySpawnerWorking = true;
        bonusSpawnerWorking = true;

        StartCoroutine(EnemySpawner());
        StartCoroutine(BonusSpawner());

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

    IEnumerator BonusSpawner()
    {
        while (bonusSpawnerWorking)
        {
            Instantiate(tripleShotBonus, new Vector3(Random.Range(-8.5f, 8.5f), 6.5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(10);
        }

    }

    public void StopEnemySpawner()
    {
        enemySpawnerWorking = false;
    }

    public void StopBonusSpawner()
    {
        bonusSpawnerWorking = false;
    }

}
