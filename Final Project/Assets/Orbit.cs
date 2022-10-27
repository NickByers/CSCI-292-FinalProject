using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GridBrushBase;

public class Orbit : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int _RotationSpeed = 100;
    [SerializeField] int _RotationDirection = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, 0, _RotationDirection * _RotationSpeed * Time.deltaTime); //rotates 50 degrees per second around z axis  
    }
}
