using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public float a, b;

        // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Sum(a,b));
        Debug.Log(Div(a,b));
        Debug.Log(Prod(a,b));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float Sum(float x, float y)
    {
        return (x + y);
    }
    float Prod(float x, float y)
    {
        return (x * y);
    }
    float Div(float x, float y)
    {
        if (y == 0)
        {
            Debug.Log("Error");
            return 0;
        }
        else
        {
            return (x / y);
        }
    }


}
