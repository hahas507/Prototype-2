using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    [SerializeField]
    private float topBound = 30f;

    [SerializeField]
    private float lowerBound = -10f;

    private void Start()
    {
    }

    private void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("게임 오버!");
            Destroy(gameObject);
        }
    }
}