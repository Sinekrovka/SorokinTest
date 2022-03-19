using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    
    public static SpawnController Instance;

    private float _speed;
    private float _time;
    private float _distance;

    private void Awake()
    {
        Instance = this;
    }

    public void StartNewSpawn(float speed, float time, float distance)
    {
        StopCoroutine(Spawn());
        _speed = speed;
        _time = time;
        _distance = distance;
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(_time);
        GameObject newSpawn = Instantiate(prefab);
        newSpawn.transform.DOMoveZ(_distance, _distance/_speed).OnComplete(delegate { Destroy(newSpawn); });
        StartCoroutine(Spawn());
    }
}
