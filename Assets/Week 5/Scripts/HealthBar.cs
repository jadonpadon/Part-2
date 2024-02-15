using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Knight knight;
    public Slider slider;

    private void Start()
    {
        knight = GetComponent<Knight>();
    }

    public void Update()
    {
        slider.value = knight.health;
    }

}
