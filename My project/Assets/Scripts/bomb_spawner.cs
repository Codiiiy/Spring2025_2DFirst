using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_spawner : MonoBehaviour
{

    public GameObject itemPrefab_Battery;
    public GameObject itemPrefab_Bomb;
    public float squareSize;

    // Start is called before the first frame update
    void Start()
    {  
        
        for(int i = 0; i < 3; i++)
        {
            spawObject(itemPrefab_Battery);
            spawObject(itemPrefab_Bomb);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
       // if(Input.GetKeyDown(KeyCode.B))
       // {
         //   spawObject();
       // }
    }

    void spawObject(GameObject item)
    {

        float x = Random.Range(-squareSize / 2, squareSize / 2);
        float y = Random.Range(-squareSize / 2, squareSize / 2);
        Vector3 randomPos = new Vector3(x, y, 0) + transform.position;
        Instantiate(item, randomPos, Quaternion.identity);

    }
}
