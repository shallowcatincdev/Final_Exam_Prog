using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{

    Transform _transform;
    [SerializeField] UIManager _uimanager;
    
    bool move = false;
    int fall = 0;
    bool moveOnX = true;

    public float ballSpeed = 1f;

    void OnClick()
    {
        if (!move)
        {
            move = true;
            _uimanager.begin();
        }
        else if (moveOnX && fall != 0)
        {
            moveOnX = false;
        }
        else if (fall != 0)
        { 
            moveOnX = true; 
        }
    }

    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            fall--;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            fall++;
        }
        
        if (collision.gameObject.tag == "Gem")
        {
            Destroy(collision.gameObject);
        }
    }


    void FixedUpdate()
    {
        if (move)
        {
            if (moveOnX) 
            {
                _transform.position += new Vector3(ballSpeed / 100, 0, 0);
            }
            else
            {
                _transform.position += new Vector3(0, 0, ballSpeed / 100);
            }
        }
        if (fall == 0)
        {
            _transform.position += new Vector3(0, -ballSpeed / 50, 0);
        }
    }

    public bool IsFall()
    {
        if (fall == 0)
        {
            return true;
        }
        else { return false; }
    }

}
