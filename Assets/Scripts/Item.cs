﻿using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public string ItemName;
    public Sprite Icon;
    public AudioClip audio;
    public float attackSpeed;
}
