using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSpawner : MonoBehaviour
{
    public GameObject shieldUpgrade;
    public GameObject damageUpgrade;
    public static bool spawnUpgrades = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int number = Random.Range(1, 10000);

        if (number < 5 && spawnUpgrades)
        {

            GameObject newUpgrade;

            if (Player.shieldBool) // if the player already has a shield give them extra damage
            {
                newUpgrade = Instantiate(damageUpgrade) as GameObject;
            }
            else
            {
                newUpgrade = Instantiate(shieldUpgrade) as GameObject;
            }

                newUpgrade.transform.parent = transform;
                Object.Destroy(newUpgrade, 5.0f);

        }
    }
}
