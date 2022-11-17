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
    public static bool shieldBool = false;
    public static bool doubleDamage = false;
    public GameObject bullet;
    public GameObject ship;
    SpriteRenderer sprite;
    //public AudioSource source;
    //public AudioClip bulletSoundEffect;
    void Start()
    {
        shieldBool = false;
        doubleDamage = false;
        InvokeRepeating("Shoot", 0.5f, 0.1f);  //1s delay, repeat every 1s
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameState.GameIsOver)
        {
            if (shieldBool)
            {
                Shield();
            }
            if (!shieldBool)
            {
                sprite = ship.GetComponent<SpriteRenderer>();
                sprite.color = new Color(1, 1, 1);
            }
            if (doubleDamage)
            {
                Invoke("ToggleDamageUpgrade", 3.0f);
            }
            if (Time.timeScale < 1.0f)
            {
                Time.timeScale = Time.timeScale * 1.01f;
            }

            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                rotationDirection = rotationDirection * -1;
                Time.timeScale = 0.1f;
            }

            transform.Rotate(0, 0, rotationDirection * rotationSpeed * Time.deltaTime); 
        }
    }

    void Shoot()
    {

        //source.PlayOneShot(bulletSoundEffect);
        GameObject newBullet = Instantiate(bullet, ship.transform.position, ship.transform.rotation) as GameObject;
        newBullet.transform.parent = transform;

    }

    void Shield()
    {
        
        sprite = ship.GetComponent<SpriteRenderer>();
        sprite.color = new Color(0, 1, 1);
    }

    void ToggleDamageUpgrade()
    {
        Player.doubleDamage = false;
    }
    
}
