//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Facebook.Unity;
//using Facebook.Unity.Settings;

//public class FacebookManager : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Awake ()
//    {
//        if (!FB.IsInitialized) {
//            // Initialize the Facebook SDK
//            FB.Init(InitCallback, OnHideUnity);
//        } else {
//            // Already initialized, signal an app activation App Event
//            FB.ActivateApp();
//        }
//    }

//    private void InitCallback ()
//    {
//        if (FB.IsInitialized) {
//            // Signal an app activation App Event
//            FB.ActivateApp();
//            Debug.LogWarning("Facebook ID:" + FB.AppId);
//            // Continue with Facebook SDK
//            // ...
//        } else {
//            Debug.Log("Failed to Initialize the Facebook SDK");
//        }
//    }

//    private void OnHideUnity (bool isGameShown)
//    {
//        if (!isGameShown) {
//            // Pause the game - we will need to hide
//            Time.timeScale = 0;
//        } else {
//            // Resume the game - we're getting focus again
//            Time.timeScale = 1;
//        }
//    }
//}
