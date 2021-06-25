
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Car : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public float rotationSpeed;

    public abstract void Moving(float _power,int _direction);
    public abstract void Inpuing();

    public abstract void Turning();
}