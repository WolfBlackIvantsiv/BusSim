
using UnityEngine;
public class Bus : Car
{
    public float Power;
    private void Start()
    {

    }
    void Update()
    {
        Inpuing();
    }

    private void FixedUpdate()
    {
        Turning();
    }
    public override void Moving(float _power,int _direction)
    {
        switch (_direction)
        {
            case 0:
                rigidbody.AddForce(Vector3.right * _power,ForceMode.Impulse);
                break;
            case 1:
                rigidbody.AddForce(Vector3.left * _power,ForceMode.Impulse);
                break;
        }

    }

    public override void Inpuing()
    {
        if (Input.GetKey(KeyCode.W)){
            Moving(Power, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Moving(Power, 1);
        }
    }

    public override void Turning()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //turning left
        }

        if (Input.GetKey(KeyCode.D))
        {
            //turning right
        }
    }
}