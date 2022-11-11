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

    }

    // Update is called once per frame
    void Update()
    {

        if (Player.doubleDamage) { 

            
            sprite = GetComponent<SpriteRenderer>();
            sprite.color = new Color(1, 0, 0);
        }
        float step = 5 * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, SpaceStation.transform.position, step);
        transform.Rotate(0, 0, Player.rotationDirection * (Player.rotationSpeed * 1.7f ) * Time.deltaTime); //rotates 50 degrees per second around z axis
        transform.Translate(Vector2.right * Player.rotationDirection * 2 * Time.deltaTime);
    }


}
