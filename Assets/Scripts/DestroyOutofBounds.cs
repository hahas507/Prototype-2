using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    [SerializeField]
    private float topBound = 30f;

    private void Start()
    {
    }

    private void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }
}