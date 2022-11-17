using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Image healthBarImage;
    public void UpdateHealthBar() { 


        // Source: medium.com/swlh/game-dev-how-to-make-health-bars-in-unity-from-beginner-to-advanced-9a1d728d0cbf
        healthBarImage.fillAmount = Mathf.Clamp(BlackHole._Health / BlackHole._MaxHealth, 0, 1f);
    }
}
