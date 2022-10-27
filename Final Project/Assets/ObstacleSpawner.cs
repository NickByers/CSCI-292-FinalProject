using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Obstacle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int number = Random.Range(1, 5000);

        if(number < 5)
        {
            GameObject newObstacle = Instantiate(Obstacle) as GameObject;
            newObstacle.transform.parent = transform;

        }
    }
}
