using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class TestDependentObjectFromPrefab : MonoBehaviour
{
    [Inject]
    public ITestInterface TestInterface { get; private set; }

    private void Awake()
    {
        print( $"[{gameObject.name}] {TestInterface.GetName()}");
    }

}
