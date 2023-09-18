using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AppearAfterimage : MonoBehaviour
{
    private List<GameObject> pool = new List<GameObject>();
    [SerializeField] private GameObject afterimagePrefab;
    public void Appear(Vector3 _origin,Quaternion _rot)
    {
        GameObject afterimage = GetFromPool();
        if(!afterimage.activeSelf) afterimage.SetActive(true);
        afterimage.transform.position = _origin;
        afterimage.transform.rotation = _rot * transform.rotation;
        afterimage.transform.parent = transform;
        DOVirtual.DelayedCall(0.5f, () =>
        {
            afterimage.SetActive(false);
        });
    }

    private GameObject GetFromPool()
    {
        for(int i = 0; i < pool.Count; i++)
        {
            if (!pool[i].activeSelf) return pool[i];
        }
        GameObject newObj = Instantiate(afterimagePrefab);
        pool.Add(newObj);
        return newObj;
    }
}
