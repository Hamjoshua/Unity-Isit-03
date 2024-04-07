using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple : MonoBehaviour
{
    // таймеры для того, чтобы не спамило в консоль
    int _isFixUpdatedTimer = 3;
    int _isUpdatedTimer = 3;
    int _isLateUpdatedTimer = 3;


    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("Enabled");
    }

    private void LateUpdate()
    {
        if (_isLateUpdatedTimer > 0)
        {
            _isLateUpdatedTimer -= 1;
            Debug.Log("Late Update");
        }       
    }

    private void FixedUpdate()
    {
        if (_isFixUpdatedTimer > 0)
        {
            _isFixUpdatedTimer -= 1;
            Debug.Log("Fixed Update");
        }
    }

    private void OnDisable()
    {
        Debug.Log("Disabled");
    }

    private void OnDestroy()
    {
        Debug.Log("Destroy");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        if (_isUpdatedTimer > 0)
        {
            _isUpdatedTimer -= 1;
            Debug.Log("Update");
        }
    }
}
