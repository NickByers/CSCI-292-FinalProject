using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int _RotationSpeed = 100;
    int _RotationDirection = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale < 1.0f)
        {
            Time.timeScale = Time.timeScale * 1.01f;
        }

        if (Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.Mouse0))
        {
            _RotationDirection = _RotationDirection * -1;
            Time.timeScale = 0.1f;
        }
        
        transform.Rotate(0, 0, _RotationDirection * _RotationSpeed * Time.deltaTime); //rotates 50 degrees per second around z axis

    }

    void Shoot()
    {

    }
}
