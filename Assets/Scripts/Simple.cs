using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple : MonoBehaviour
{
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
            Debug.Log("Fixed Update");
        }       
    }

    private void FixedUpdate()
    {
        if (_isLateUpdatedTimer > 0)
        {
            _isFixUpdatedTimer -= 1;
            Debug.Log("Late Update");
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

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (_isUpdatedTimer > 0)
        {
            _isUpdatedTimer -= 1;
            Debug.Log("Updated");
        }
    }
}
