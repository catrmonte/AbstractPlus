using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pasta : IPasta
{
    private float m_tastiness = 3f;

    public float getTastiness()
    {
        return m_tastiness;
    }
}
