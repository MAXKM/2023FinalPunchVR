using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearAfterimage : MonoBehaviour
{
    [SerializeField] GameObject afterimagePrefab;
    public void Appear(Vector3 _origin,Quaternion _rot)
    {
        GameObject afterimage = Instantiate(afterimagePrefab, _origin, Quaternion.identity);
        afterimage.transform.rotation = _rot * transform.rotation;
    }
}
