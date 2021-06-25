
using UnityEngine;

public class MainCamera : CameraControler
{
    public new Camera camera;
    public Transform target;
    void Start()
    {
        
    }

    void Update()
    {
        CameraScene();
    }

    void CameraScene()
    {
        LookAt(target);
    }
    
    public override void LookAt(Transform _target)
    {
        camera.transform.LookAt(_target);
    }

    public override void Following(Transform _target)
    {
        transform.position = target.position - transform.position;
    }
}
