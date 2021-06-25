using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CameraControler : MonoBehaviour
{
    public abstract void LookAt(Transform _target);
    public abstract void Following(Transform _target);
}
