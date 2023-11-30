using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Transform _transform;
    [SerializeField] GameObject _ball;
    [SerializeField] BallControler _ballControler;

    Vector3 offset = new Vector3(-11, 15.1f, -14);

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        if (!_ballControler.IsFall())
        {
            _transform.position = _ball.GetComponent<Transform>().position + offset;
        }
    }
}
