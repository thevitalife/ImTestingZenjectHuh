using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class TestDependentObject : MonoBehaviour
{
    //[Inject]
    public ITestInterface TestInterface { get; private set; }

    public TestNonMBObj TestNonMBObj { get; private set; }

    [Inject]
    public void Construct(ITestInterface testInterface, TestNonMBObj testNonMBObj)
    {
        TestInterface = testInterface;
        TestNonMBObj = testNonMBObj;
    }
    private void Awake()
    {
        print( $"[{gameObject.name}] {TestInterface.GetName()}");
        print($"[{gameObject.name}] . [TestNonMBObj] {TestNonMBObj.GetTestName()}");

    }

}
