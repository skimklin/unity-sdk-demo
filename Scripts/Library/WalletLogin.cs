using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public class Web3Wallet
{
#if (UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR
        private static string url = "https://metamask.app.link/dapp/chainsafe.github.io/game-web3wallet/";
#else
    private static string url = "https://chainsafe.github.io/game-web3wallet/";
#endif
    public static async Task<string> Sign(string _message)
    {
        // open application
        string message = Uri.EscapeDataString(_message);
        Application.OpenURL(url + "?action=sign" + "&message=" + message);
        // set clipboard to empty
        GUIUtility.systemCopyBuffer = "";
        // wait for clipboard response
        string clipBoard = "";
        while (clipBoard == "")
        {
            clipBoard = GUIUtility.systemCopyBuffer;
            await Task.Delay(100);
        }
        // check if clipboard response is valid
        if (clipBoard.StartsWith("0x") && clipBoard.Length == 132)
        {
            return clipBoard;
        }
        else
        {
            throw new Exception("sign error");
        }
    }
}