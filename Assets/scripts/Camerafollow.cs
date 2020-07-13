using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform birdTransform;
    Vector3 range;
    private void Awake()
    {
        //calculating the range between the camera's position and the bird's position
        range = transform.position - birdTransform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Make the camera follow the bird's mouvement on the X axis
        //and keep the Y position constant
        transform.position = new Vector3(range.x + birdTransform.position.x, transform.position.y, range.z + birdTransform.position.z);
        
    }
}
