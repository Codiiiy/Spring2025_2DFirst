using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_spawner : MonoBehaviour
{
    public GameObject itemPrefab_Battery;
    public GameObject itemPrefab_Bomb;
    public GameObject itemPrefab_Box;
    public float squareSize;

    private float tick = 0f;
    public float spawnInterval = 2f;
    public float spawnSpeedMultiplier = 0.99f;

    void Update()
    {
        //while(score_manager.gameMaster == true)
       // {
            tick += Time.deltaTime;
            if (tick >= spawnInterval)
            {
                tick = 0f;
                int randomIndex = Random.Range(0, 3);
                GameObject item = randomIndex == 0 ? itemPrefab_Battery : randomIndex == 1 ? itemPrefab_Bomb : itemPrefab_Box;
                SpawnObject(item);
                spawnInterval *= spawnSpeedMultiplier;
            }
       //}

    }

    void SpawnObject(GameObject item)
    {
        float x = Random.Range(-squareSize / 2, squareSize / 2);
        float y = Random.Range(-squareSize / 2, squareSize / 2);
        Vector3 randomPos = new Vector3(x, y, 0) + transform.position;
        Instantiate(item, randomPos, Quaternion.identity);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Vector3 center = transform.position;
        Vector3 size = new Vector3(squareSize, squareSize, 0);
        Gizmos.DrawWireCube(center, size);
    }
}
