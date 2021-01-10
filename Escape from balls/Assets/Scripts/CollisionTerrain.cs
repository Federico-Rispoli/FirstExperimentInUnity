using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTerrain : MonoBehaviour
{
    private int mid = 0;
    [SerializeField] private float vel = 2f;
    Vector3 vect;

    private void Start()
    {
        if (gameObject.transform.position.x >= mid)
        {
            vect = new Vector3(-vel, 0);
        }
        else
        {
            vect= new Vector3(vel, 0);
        }
    }

    private void Update()
    {
        transform.position += vect * Time.deltaTime;
    }
}
