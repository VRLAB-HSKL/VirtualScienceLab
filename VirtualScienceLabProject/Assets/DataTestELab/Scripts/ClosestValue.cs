using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class ClosestValue 
{
    public static float ClosestTo(this IEnumerable<float> collection, float target)
    {
        return collection.OrderBy(x => Math.Abs(target - x)).First();
    }
}
