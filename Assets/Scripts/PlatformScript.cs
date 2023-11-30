using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    Transform _transform;

    bool fall = false;
    float fallTime = 0;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("fall");
            fall = true;
        }
    }

    private void Update()
    {

        if (fall)
        {
            if (fallTime >= 1)
            {
                _transform.position += new Vector3(0, -2 * Time.deltaTime, 0);
            }
            else if (fallTime >= 2.5)
            {
                Destroy(gameObject);
            }
            else
            {
                fallTime += Time.deltaTime;
            }
        }
    }
}
