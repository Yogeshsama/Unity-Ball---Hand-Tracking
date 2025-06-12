using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public GameObject cubePrefab;
    public int baseCount = 5;
    public float spacing = 2f;
    public float height = 1.1f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < baseCount; i++)
        {
            int cubesInLayer = baseCount - i;
            float startX = -(cubesInLayer - 1) * spacing / 2f;

            for (int j = 0; j < cubesInLayer; j++)
            {
                Vector3 position = new Vector3(startX + j * spacing, i * height, 0);
                
               GameObject cube =  Instantiate(cubePrefab, position, Quaternion.identity, this.transform);
            }
        }
    }

    
}
