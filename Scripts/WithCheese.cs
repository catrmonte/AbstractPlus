using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithCheese : PastaDecorator
{
    private float m_tastiness = 8f;

    public WithCheese(IPasta pasta) : base(pasta) { }

    public override float getTastiness()
    {
        return base.getTastiness() + m_tastiness;
    }
}
