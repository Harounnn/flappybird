using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    //public values are editable from the inspector
    public float minY;
    public float maxY;
    public float distance;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Obstacle")
        {
            //choose random Y position
            float obstacleY = Random.Range(minY, maxY);
            //choose a position for the new obstacle
            Vector3 spawnPosition = new Vector3(transform.position.x + distance, obstacleY, 0);
            //move obstacle to Spawnposition
            col.gameObject.transform.position = spawnPosition;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
