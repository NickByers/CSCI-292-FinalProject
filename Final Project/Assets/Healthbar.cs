using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Image healthBarImage;
    public void UpdateHealthBar()
    {
        //Debug.Log("Health Updated " + " " + (BlackHole._Health / BlackHole._MaxHealth)+ " " + healthBarImage.fillAmount);
        healthBarImage.fillAmount = Mathf.Clamp(BlackHole._Health / BlackHole._MaxHealth, 0, 1f);
    }
}
