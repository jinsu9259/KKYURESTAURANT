using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_BaseHp : MonoBehaviour
{
    public float curHealth;
    public float maxHealth;


    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHpSlider();
    }

    private void UpdateHpSlider()
    {
    }
}
