using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemy;
    public bool spawnerWorking;


    private void Start()
    {
        spawnerWorking = true;
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        Transform parentObj = GameObject.FindWithTag("EnemyParent").transform;

        while (spawnerWorking)
        {
            Instantiate(enemy, new Vector3(Random.Range(-8.5f, 8.5f), 6.5f, 0), Quaternion.identity, parentObj);
            yield return new WaitForSeconds(5);
        }

    }

    public void StopSpawner()
    {
        spawnerWorking = false;
    }


}
