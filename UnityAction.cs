using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityAction : MonoBehaviour
{

    async void Start()
    {

    }

    async void onWalletLogin()
    {
        // get current timestamp
        int timestamp = (int)(System.DateTime.UtcNow.Subtract(new System.DateTime(1970, 1, 1))).TotalSeconds;
        // set expiration time
        int expirationTime = timestamp + 60;
        // set message
        string message = expirationTime.ToString();
        // sign message
        string signature = await Web3Wallet.Sign(message);
        Debug.Log(signature);
    }
}
