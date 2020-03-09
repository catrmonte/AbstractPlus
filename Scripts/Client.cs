using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public PastaSpawner mPastaSpawner;
    public Text text;

    void Update()
    {
        IPasta pasta;

        // P is for plain pasta
        if (Input.GetKeyDown("p"))
        {
            pasta = mPastaSpawner.SpawnPlainPasta();
            text.text = "Plain pasta = tastiness: " + pasta.getTastiness();
        }

        // S is for Sauce
        if (Input.GetKeyDown("s"))
        {
            pasta = mPastaSpawner.SpawnSaucePasta();
            text.text = "Sauce + plain pasta = tastiness: " + pasta.getTastiness();
        }

        // M is for meatball
        if (Input.GetKeyDown("m"))
        {
            pasta = mPastaSpawner.SpawnMeatballPasta();
            text.text = "Meatball + Sauce + Plain pasta = tastiness: " + pasta.getTastiness();
        }

        // C is for Cheeseeeee
        if (Input.GetKeyDown("c"))
        {
            pasta = mPastaSpawner.SpawnCheesePasta();
            text.text = "Cheese + Meatball + Sauce + Plain pasta = tastiness: " + pasta.getTastiness();
        }
    }
}
