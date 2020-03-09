using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithMeatball : PastaDecorator
{
    private float m_tastiness = 15f;

    public WithMeatball(IPasta pasta) : base(pasta) { }

    public override float getTastiness()
    {
        return base.getTastiness() + m_tastiness;
    }
}
