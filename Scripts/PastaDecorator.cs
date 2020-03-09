using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PastaDecorator : IPasta
{
    protected IPasta mPastaDish;

    public PastaDecorator(IPasta pasta)
    {
        mPastaDish = pasta;
    }

    public virtual float getTastiness()
    {
        return mPastaDish.getTastiness();
    }
}
