using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeNeed;
    private bool isTimed = true;
    private float delta = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && isTimed)
        {
            Instantiate(dogPrefab, gameObject.transform.position, dogPrefab.transform.rotation);
            isTimed = false;
        }
        else{
            delta += Time.deltaTime;
            if (delta > timeNeed)
            {
                delta = 0;
                isTimed = true;
            }
        }
    }
}
