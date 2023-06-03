using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSlider3D : MonoBehaviour
{
    private Slider HealthSlider3d;
    public Slider HealthSlider2d;

    public int health;
    // Start is called before the first frame update
    void Start()
    {
        HealthSlider3d = GetComponent<Slider>();
        HealthSlider2d = HealthSlider2d.GetComponent<Slider>();      // my own perfect edit
        HealthSlider2d.maxValue = health;
        HealthSlider3d.maxValue = health;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(Camera.main.transform);
        transform.Rotate(0, 180, 0);
    }

    void Update()
    {
        HealthSlider3d.value = health;
        HealthSlider2d.value = HealthSlider3d.value;
    }
}
