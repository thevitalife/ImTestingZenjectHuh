using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class TestNonMBObj
{
    private ITestInterface testInterface;
    public TestNonMBObj(ITestInterface testInterface)
    {
        this.testInterface = testInterface;
    }

    public string GetTestName()
    {
        return testInterface.GetName();
    }
}

public class TestContainerInstaller : MonoInstaller
{
    [SerializeField]
    private TestObject testObject;

    [SerializeField]
    private TestObject prefabObject;
    public override void InstallBindings()
    {

        Container.Bind<ITestInterface>().To<TestObject>().FromInstance(testObject);
        if (prefabObject) Container.Bind<ITestInterface>().To<TestObject>().FromComponentInNewPrefab(prefabObject).WhenInjectedInto<TestDependentObjectFromPrefab>();
        Container.Bind<TestNonMBObj>().AsSingle();

    }
}
