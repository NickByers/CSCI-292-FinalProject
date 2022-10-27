using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    [SerializeField] int _Health = 1000;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Player.rotationDirection * Player.rotationSpeed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        _Health = _Health - 1;
    }
}
