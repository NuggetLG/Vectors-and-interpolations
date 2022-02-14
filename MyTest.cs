using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTest : MonoBehaviour
{
    [SerializeField]
    MyVector2d First;
    [SerializeField]
    MyVector2d Second;
    [SerializeField]
    [Range(0, 1)]
    public float range = 0.0f;

    private void Start()
    {


    }

    private void Update()
    {

        First.Drawn();
        Second.Drawn();
        First.Lerp(First, Second, range).Drawn();
    }
}

