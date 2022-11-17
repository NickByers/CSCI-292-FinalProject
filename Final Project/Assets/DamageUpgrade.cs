using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageUpgrade : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer sprite;
    bool isActive = false;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = new Color(0, 1, 0, 0.2f);
        Invoke("MakeActive", 2);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PlayerShip" && isActive)
        {
            Player.doubleDamage = true;
            Destroy(gameObject);
            Debug.Log("Player Hit Damage!");
           

        }
    }
    void MakeActive()
    {
        sprite.color = new Color(0, 1, 0, 1);
        isActive = true;
    }

}
