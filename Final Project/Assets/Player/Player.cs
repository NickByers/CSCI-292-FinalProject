using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GridBrushBase;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public static int rotationSpeed = 100;
    public static int rotationDirection = 1;
    public GameObject bullet;
    public GameObject ship;
    void Start()
    {
        InvokeRepeating("Shoot", 0, 0.3f);  //1s delay, repeat every 1s
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
            rotationDirection = rotationDirection * -1;
            Time.timeScale = 0.1f;
        }
        
        transform.Rotate(0, 0, rotationDirection * rotationSpeed * Time.deltaTime); //rotates 50 degrees per second around z axis
    }

    void Shoot()
    {
        GameObject newBullet = Instantiate(bullet, ship.transform.position, ship.transform.rotation) as GameObject;
        newBullet.transform.parent = transform;

    }
    
}
