
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cube;
    private Cubes _cubesTime;
    private float _timer;

    private void Start()
    {
        _cubesTime = GameObject.Find("TimeForAppearance").GetComponent<Cubes>();
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        if (!(_timer >= _cubesTime.Time)) return;
        Instantiate(cube, transform.position, transform.rotation);
        _timer = 0;
    }
}