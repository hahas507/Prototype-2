using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float preventSpam = 1f;
    private float timer = 0f;
    private bool canFire = true;

    private void Update()
    {
        if (canFire)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                canFire = false;
                timer = 0f;
            }
        }
        else if (!canFire)
        {
            timer += Time.deltaTime;

            //Debug.Log(timer);

            if (timer >= preventSpam)
            {
                canFire = true;
            }
        }
    }
}