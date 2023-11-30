using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    Transform _transform;

    [SerializeField] GameObject _platformPrefab;
    [SerializeField] GameObject _gemPrefab;
    [SerializeField] BallControler _ballControler;

    int totalPlatforms = 0;
    float spawnTime;
    void Start()
    {
        _transform = GetComponent<Transform>();
        while (totalPlatforms < 20)
        {
            SpawnPlatform();
            totalPlatforms++;
        }
        
    }

    void Update()
    {
        if (spawnTime >= 0.2 && !_ballControler.IsFall())
        {
            SpawnPlatform();
            spawnTime = 0;
        }
        else
        {
            spawnTime += Time.deltaTime;
        }
    }

    private void SpawnPlatform()
    {
        GameObject plat = Instantiate(_platformPrefab);
        plat.GetComponent<Transform>().position = _transform.position;


        if (Random.Range(0, 5) == 0)
        {
            SpawnGem();
        }


        int direct = Random.Range(0, 2);
        if (direct == 0)
        {
            _transform.position += new Vector3(2, 0, 0);
        }
        else
        {
            _transform.position += new Vector3(0, 0, 2);
        }
    }

    void SpawnGem()
    {
        float posx = Random.Range(-80f, 80f);
        float posz = Random.Range(-80f, 80f);
        GameObject gem = Instantiate(_gemPrefab);
        gem.GetComponent<Transform>().position = _transform.position + new Vector3(posx / 100, 1, posz / 100);
    }
}
