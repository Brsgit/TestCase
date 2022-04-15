﻿
using UnityEngine;

public interface IShootable
{
    float Scale { get; }
    int Damage { get; }
    float Speed { get; }
    float LifeTime { get; }
    void Shoot(Vector3 destination);
}