using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class UserProfile 
{
    public string Username;
    public Color Color;
    public string Score;
    public string ImageName;

    [NonSerialized]
    public Sprite Image;
}
