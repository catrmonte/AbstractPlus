using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PastaSpawner : MonoBehaviour
{
    public PastaFactory mFactory;

    private IPasta mPlain;
    private IPasta mSauce;
    private IPasta mMeatball;
    private IPasta mCheese;

    public IPasta SpawnPlainPasta()
    {
        mPlain = new Pasta();
        return mPlain;
        //text.text = "Spawned Plain Pasta: Tastiness: " + mPlain.getTastiness();
    }

    public IPasta SpawnSaucePasta()
    {
        mSauce = new Pasta();
        mSauce = mFactory.GetPasta(ToppingType.Sauce, mSauce);
        return mSauce;
    }

    public IPasta SpawnMeatballPasta()
    {
        mMeatball = new Pasta();
        mMeatball = mFactory.GetPasta(ToppingType.Sauce, mMeatball);
        mMeatball = mFactory.GetPasta(ToppingType.Meatball, mMeatball);
        return mMeatball;
    }

    public IPasta SpawnCheesePasta()
    {
        mCheese = new Pasta();
        mCheese = mFactory.GetPasta(ToppingType.Sauce, mCheese);
        mCheese = mFactory.GetPasta(ToppingType.Meatball, mCheese);
        mCheese = mFactory.GetPasta(ToppingType.Cheese, mCheese);
        return mCheese;
    }
}
