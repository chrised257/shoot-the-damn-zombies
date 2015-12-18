using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemyPrefab;

    public static ArrayList spawnerList = new ArrayList();

    private static int enemyCount = 0;
    private static float previousEnemyCount = 1f;

    void Awake()
    {
        spawnerList.Add(this);
    }

	void Start () {
        requestSpawns();
	}

    public void spawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation);
    }

    protected static void requestSpawns()
    {
        if (enemyCount > 0)
        {
            return;
        }

        previousEnemyCount = Mathf.CeilToInt(1.5f * previousEnemyCount);
        enemyCount = Mathf.FloorToInt(previousEnemyCount);
        

        for (int i = 0; i < enemyCount; i++)
        {
            ((EnemySpawner)spawnerList[Random.Range(0, spawnerList.Count)]).spawnEnemy();
        }
    }

    public static void reportEnemyDead()
    {
        enemyCount--;
        requestSpawns();
    }
}
