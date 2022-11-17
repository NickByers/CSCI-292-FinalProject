using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    [SerializeField] public static float  _Health = 2000f;
    [SerializeField] public static float _MaxHealth = _Health;
    public Healthbar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.UpdateHealthBar();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Player.rotationDirection * Player.rotationSpeed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject); // destroy bullet
        //Debug.Log("bullet hit");
        TakeDamage();
    }

    public void TakeDamage()
    {
        if (Player.doubleDamage)
        {
            _Health = _Health - 2f;
        }
        _Health = _Health - 1f;
        //Debug.Log(_Health);
        healthBar.UpdateHealthBar();
    }
}
