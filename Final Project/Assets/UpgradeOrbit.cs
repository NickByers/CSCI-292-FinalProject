using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeOrbit : MonoBehaviour
{
    public static int rotationDirection = 1;
    [SerializeField] public static int rotationSpeed = 60;
    void Start()
    {

        Destroy(transform.gameObject, 8);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationDirection * rotationSpeed * Time.deltaTime); //rotates 50 degrees per second around z axis
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "PlayerShip")
        {
            Debug.Log("Upgrade Hit");
        }
    }
}
