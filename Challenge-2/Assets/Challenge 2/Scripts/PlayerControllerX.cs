using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float delay = 20.0f;

    // Update is called once per frame
    void Update()
    {
        delay = delay - 1;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && delay <= 0.0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            delay = 20.0f;
        }
    }
}
