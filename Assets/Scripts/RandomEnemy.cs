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
    }
    void Spawn()
    {
        int countObject = Random.Range(4, 8);
        for (int i = 0; i < countObject; i++)
        {
            float randomX = Random.Range(xMin, xMax);
            float randomY = Random.Range(yMin, yMax);
            Instantiate(cube, new Vector2(randomX, randomY), Quaternion.identity);
        }
    }
}
