using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RolleteController : MonoBehaviour
{
    float _lotSpeed = 0;
    public float lotSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lotSpeed = lotSpeed;
        }
        this.transform.Rotate(0, 0, this._lotSpeed);
        this._lotSpeed *= 0.98f;
    }
}
