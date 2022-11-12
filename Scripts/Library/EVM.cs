//using System;
//using System.Collections.Generic;
//using System.Numerics;
//using System.Text;
//using System.Threading.Tasks;
//using Models;
//using UnityEngine;
//using UnityEngine.Networking;
//using Newtonsoft.Json;
//using SDKConfiguration;

//public class EVM
//{
//    //public class Response<T> { public T response; }

//    //private static readonly string host = "https://api.gaming.chainsafe.io/evm";
//    //private static readonly string hostVoucher = "https://lazy-minting-voucher-signer.herokuapp.com";

//    //public static async Task<string> Verify(string _message, string _signature)
//    //{
//    //    WWWForm form = new WWWForm();
//    //    form.AddField("projectId", PlayerPrefs.GetString("ProjectID"));
//    //    form.AddField("message", _message);
//    //    form.AddField("signature", _signature);
//    //    string url = host + "/verify";
//    //    using (UnityWebRequest webRequest = UnityWebRequest.Post(url, form))
//    //    {
//    //        await webRequest.SendWebRequest();
//    //        Response<string> data = JsonUtility.FromJson<Response<string>>(System.Text.Encoding.UTF8.GetString(webRequest.downloadHandler.data));
//    //        return data.response;
//    //    }
//    //}

//}