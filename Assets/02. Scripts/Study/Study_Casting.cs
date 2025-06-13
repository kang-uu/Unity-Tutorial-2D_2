using System;
using System.Collections.Generic;
using UnityEngine;

public class Study_Casting : MonoBehaviour
{
    public List<int> intList = new List<int>();
    public List<GameObject> objList = new List<GameObject>();
    public List<Vector3> vecList = new List<Vector3>();
    public List<bool> boolList = new List<bool>();
    public List<string> strList = new List<string>();
    
    
    
    void Start()
    {
        Monster m = new Monster();

        // Orc o1 = m; // 암시적 형변환 X
        // Orc o = (Orc)m; // 명시적 형변환 -> 에러

        Orc o = m as Orc; // 성공시 형변환 / 실패시 null

        if (o != null)
        {
            Debug.Log(o);
        }
        else
        {
            Debug.Log("형변환 되지 않음");
        }
    }
}