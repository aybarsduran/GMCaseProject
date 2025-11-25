using System.Threading.Tasks;
using UnityEngine;
using Firebase;
using Firebase.Extensions;

public class FirebaseInitializer : MonoBehaviour
{
    public static bool IsFirebaseReady { get; private set; }

    private void Awake()
    {
        InitializeFirebase();
    }

    private void InitializeFirebase()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            var result = task.Result;

            if (result == DependencyStatus.Available)
            {
                IsFirebaseReady = true;
                Debug.Log("Firebase initialized successfully.");
            }
            else
            {
                Debug.LogError("Could not resolve Firebase dependencies: " + result);
            }
        });
    }
}
