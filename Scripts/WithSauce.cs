using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithSauce : PastaDecorator
{
    private float m_tastiness = 10f;

    public WithSauce(IPasta pasta) : base(pasta) { }

    public override float getTastiness()
    {
        return base.getTastiness() + m_tastiness;
    }
}
