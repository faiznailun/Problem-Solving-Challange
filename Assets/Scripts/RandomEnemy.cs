using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemy : MonoBehaviour
{
    public GameObject cube;
    public float xMin, xMax, yMin, yMax;
   
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
        StartCoroutine(SpawnCube());
    }
    void Spawn()
    {
        int countObject = Random.Range(7, 14);
        for (int i = 0; i < countObject; i++)
        {
            float randomX = Random.Range(xMin, xMax);
            float randomY = Random.Range(yMin, yMax);
            Instantiate(cube, new Vector2(randomX, randomY), Quaternion.identity);
        }
    }
    IEnumerator SpawnCube()
    {
        if (transform.childCount < 12)
        {
            float randomX = Random.Range(xMin, xMax);
            float randomY = Random.Range(yMin, yMax);
            Instantiate(cube, new Vector2(randomX, randomY), Quaternion.identity); 
        }
        yield return new WaitForSeconds(3);
        StartCoroutine(SpawnCube()); 
    }
    void Update()
    {
        
    }
}
