using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] GameObject zigzag;
    [SerializeField] GameObject tap;
    [SerializeField] GameObject highscore;
    [SerializeField] GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void begin()
    {
        zigzag.SetActive(false);
        tap.SetActive(false);
        highscore.SetActive(false);
        score.SetActive(false);
    }
}
