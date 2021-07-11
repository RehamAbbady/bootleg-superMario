using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoins : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CoinDisplay;
    public static int CoinCount;
    public static int InternalCoins;
    //static variables can be accessed from other scripts
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InternalCoins = CoinCount;
        CoinDisplay.GetComponent<Text>().text = "Coins: " + CoinCount;
        
    }
}
