using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitInit : MonoBehaviour
{
    private float moveSpeed;
    private float rangeUnit;   //유닛의 사거리에 따른 스크립트 받아오기
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 4.0f;
        rangeUnit = 6.5f;      //유닛의 사거리에 따른 스크립트 받아오기
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
