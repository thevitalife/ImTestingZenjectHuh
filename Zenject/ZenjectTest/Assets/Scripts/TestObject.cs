using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour, ITestInterface
{
    public string GetName()
    {
        return name;
    }
}
