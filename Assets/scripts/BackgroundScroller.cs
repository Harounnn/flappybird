using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            transform.position += 2*Vector3.right * GetComponent<SpriteRenderer>().bounds.size.x;
            //This line moves the background to the right
            //we use GetComponent<spriteRendrer>().bounds.size.x to get the background size
            //2* added to multiply the old statement by 2
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
