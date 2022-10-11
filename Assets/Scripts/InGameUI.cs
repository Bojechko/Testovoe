using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    [SerializeField]
    private Button _submit;

    [SerializeField]
    private InputField _inputSpeed;
    [SerializeField]
    private InputField _inputDistance;
    [SerializeField]
    private InputField _inputTime;

    private int _speed = 0;
    private int _distance = 0;
    private int _time = 0;

    private Spawner _spawner;

    private void Awake()
    {
        _submit.onClick.AddListener(OnClickHandler);
    }


    private void Start()
    {
        var spawnerObject = GameObject.Find("Spawner");
        _spawner = spawnerObject.GetComponent<Spawner>();
    }

    private void Update()
    {
        int.TryParse(_inputSpeed.text, out _speed);
        int.TryParse(_inputDistance.text, out _distance);
        int.TryParse(_inputTime.text, out _time);
    }

    private void OnClickHandler()
    {
        
        _spawner.ChangeSpawnerParameters(_time, _speed, _distance);
        Debug.Log(" À» ");
    }

}
