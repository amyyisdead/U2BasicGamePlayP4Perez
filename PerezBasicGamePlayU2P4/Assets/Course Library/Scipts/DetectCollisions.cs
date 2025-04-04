using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player")) { }
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
        else
        {
            destroy(gameObject);
            Destroy(other.gameObject);
        }
        
    }
        
    
}
