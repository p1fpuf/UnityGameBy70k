using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadspawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _roads;
    [SerializeField] private float _roadLenth;
    private GameObject _road;

    private void Start()
    {
        _road = Instantiate(_roads[Random.Range(0, _roads.Count - 1)], transform.position, Quaternion.identity);
    }


    private void Update()
    {

    }

    public void Spawn()
    {
        Vector3 position = new Vector3(0, 0, _road.transform.position.z + _roadLenth);
        _road = Instantiate(_roads[Random.Range(0, _roads.Count - 1)], position, Quaternion.identity);
    }
}