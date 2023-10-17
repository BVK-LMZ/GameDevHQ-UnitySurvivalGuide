using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    float pricePriorPatronage;
    float tipAmount;

    void Start()
    {
        bool isLucky = CoinFlip();
        Debug.Log(isLucky);  // "L" in "Log" should be uppercase

        if (isLucky)    // if true
        {
            tipAmount = pricePriorPatronage * 0.20f;  // Use "f" to indicate a float value
        }
        else
        {
            tipAmount = pricePriorPatronage * 0.10f;  // Use "f" to indicate a float value
        }
    }

    public bool CoinFlip()
    {
        System.Random random = new System.Random();  // Use "System.Random" to create a random object
        return random.Next(0, 2) == 1;  // true if 1, false if 0
    }
}

