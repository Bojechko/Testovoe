using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _cubePrefab;

    [SerializeField]  
    private int _time;
    [SerializeField]
    private int _speed;
    [SerializeField]
    private int _distance;


    private float _timeLeft = 0;


    private void Spawn()
    {        
        var clonedCube = Instantiate(_cubePrefab, transform.position, Quaternion.identity);

        var cubelogic = clonedCube.GetComponent<CubeLogic>();

        cubelogic.SetParameters(_speed, _distance);
    }


  
    void Update()
    {
        _timeLeft -= Time.deltaTime;
        if (_timeLeft <= 0)
        {
            _timeLeft = _time;
            Spawn();
        }
        
        Debug.Log(_time);
    }

    public void ChangeSpawnerParameters(int time, int speed, int distance)
    {
        _time = time;
        _speed = speed;
        _distance = distance;
    }
}
