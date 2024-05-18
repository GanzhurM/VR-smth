using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulatorMove : MonoBehaviour
{
    public Transform objectToOrbit;
    public float Angle = 0;
    public float RotateA = 0.1f;
    public bool Finished = false;
    public bool Rotate1 = false;
    public bool UpDetail = false;
    void Start()
    {

    }

    bool move()
    {
        Angle += RotateA;
        if (Angle < 90f)
        {
            transform.RotateAround(objectToOrbit.position, Vector3.up, RotateA);
            return false;
        }
        else
        {
            return true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Rotate1 == false)
        {
            Rotate1 = move();
        }
    }
}
