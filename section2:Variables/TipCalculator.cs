using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    float pricePriorPatronage;
    float tipAmount;

    public float _highTip =  0.20f;
    public float _lowTip =  0.10f;
    
    void Start()
    {
        bool isLucky = FlipCoin();  // Rename to FlipCoin
        Debug.Log(isLucky); // "L" in "Log" is uppercase

        if (isLucky)
        {
            tipAmount = pricePriorPatronage * _highTip; // Use "f" to indicate a float value
        }
        else
        {
            tipAmount = pricePriorPatronage * _lowTip; // Use "f" to indicate a float value
        }
    }

    public bool FlipCoin() // Rename to FlipCoin
    {
        System.Random random = new System.Random(); // Specify the namespace
        return random.Next(0, 2) == 1;
    }
    
}

