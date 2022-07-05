using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerTests
{
  
  
    [UnityTest]
    [Category("Fast")]
    public IEnumerator Fast_PlayModeTest()
    {
        Console.WriteLine("Hello world, from fast test!");
        var a = 2;
        var b = 2;
        var c = a + b;


        yield return null;
        Assert.AreEqual(expected: 4, actual: c);
        
    }

    [UnityTest]
    [Category("Slow")]
    public IEnumerator Slow_PlayModeTest()
    {
        Console.WriteLine("Hello world, from slow test!");
        var a = 2;
        var b = 2;
        var c = a + b;

        yield return null;
        Assert.AreEqual(expected: 4, actual: c);
        
    }
}
