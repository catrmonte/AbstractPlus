using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PastaFactory : MonoBehaviour
{
    public IPasta GetPasta(ToppingType type, IPasta pasta)
    {
        IPasta pastaPlain = new Pasta();

        switch (type)
        {
            case ToppingType.Sauce:
                pasta = new WithSauce(pasta);
                return pasta;

            case ToppingType.Meatball:
                pasta = new WithMeatball(pasta);
                return pasta;

            case ToppingType.Cheese:
                pasta = new WithCheese(pasta);
                return pasta;
        }

        return pasta;
    }
}
