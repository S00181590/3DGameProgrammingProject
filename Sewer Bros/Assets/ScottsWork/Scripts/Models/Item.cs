using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class Item 
{
    public int ID;//every item has to have a unique id 
    public string Name;
    public string Descrption;
    public float Value;
    public Color tint = Color.white;
    public Sprite Icon;

    public GameObject prefab;
         
    
}
