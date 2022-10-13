using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cube;
    private Cubes _cubesTime;
    private float timer;
    private void Start()
    {
        _cubesTime = GameObject.Find("TimeForAppearance").GetComponent<Cubes>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= _cubesTime.Time)
        {
            Instantiate(cube, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
