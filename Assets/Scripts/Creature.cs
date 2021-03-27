using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public int ageToMate;
    public int ageToDie;

    private Vector2 currentPos;
    private Environment environment;
    private int currentAge;

    public Creature(Environment envir)
    {
        environment = envir;
        currentAge = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pickDirectionToMoveIn()
    {
        
    }
}
