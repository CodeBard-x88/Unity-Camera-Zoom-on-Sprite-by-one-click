using System;
using System.Threading;
using UnityEngine;

public class BackgroundThreadDispatcher : MonoBehaviour
{
    // Starts a new thread every time this is called.
    public void RunInBackground(Action task)
    {
        Thread worker = new Thread(() =>
        {
            task(); // Bug: null input causes an unhandled exception on this thread.
            Debug.Log("Task finished"); // Unity APIs should not be called from a worker thread.
        });

        worker.Start();
    }
}
