using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GridBrushBase;


public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer sprite;

    public GameObject SpaceStation;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        sprite.color = new Color(0, 1, 0);

        if (Player.doubleDamage) { 

            sprite.color = new Color(1, 0, 0);
        }
        float step = 5 * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, SpaceStation.transform.position, step);
        transform.Rotate(0, 0, Player.rotationDirection * (Player.rotationSpeed * 1.7f ) * Time.deltaTime); 
        transform.Translate(Vector2.right * Player.rotationDirection * 2 * Time.deltaTime);
    }


}
