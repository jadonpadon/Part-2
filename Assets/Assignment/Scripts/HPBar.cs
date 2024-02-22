using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour
{
    public Shooter shooter;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        shooter = GetComponent<Shooter>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = shooter.health;
    }
}
