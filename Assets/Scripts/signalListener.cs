using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SignalListener : MonoBehaviour
{
    // Start is called before the first frame update
    public Signal signal;
    public UnityEvent signalEvent;
    public void OnSignalRaised()
    {
        signalEvent.Invoke();
    }
    
    private void OnEnable() 
    {
        signal.RegisterListener(this);
    }
    private void OnDisable() 
    {
        signal.DeRegisterListner(this);
    }
}
