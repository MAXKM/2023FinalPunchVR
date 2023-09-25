using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterimageManager : MonoBehaviour
{
    public List<Vector3> pos = new List<Vector3>() { };
    public List<Quaternion> rot = new List<Quaternion>() { };
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Store(Vector3 _pos, Quaternion _rot)
    {
        pos.Add(_pos);
        rot.Add(_rot);
    }
}
