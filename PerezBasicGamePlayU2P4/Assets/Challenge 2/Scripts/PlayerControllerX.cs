using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float coolDown = 0;

    // Update is called once per frame
    void Update()
    {
        coolDown = coolDown - Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && coolDown <=0)
        {
            coolDown = 1;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
