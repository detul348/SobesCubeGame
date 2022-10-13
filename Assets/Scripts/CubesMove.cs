using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CubesMove : MonoBehaviour
{
  private Cubes _cubesSpeed;
  private Cubes _cubesDistance;

  private void Start()
  {
    _cubesSpeed = GameObject.Find("Speed").GetComponent<Cubes>();
    _cubesDistance = GameObject.Find("Distance").GetComponent<Cubes>();
  }

  void Move()
  {
    transform.Translate(Vector3.forward * _cubesSpeed.Speed);
  }
  private void Update()
  {
    if (transform.position.z >= _cubesDistance.Distance)
    {
      Destroy(gameObject);
    }
    Move();
  }
}
