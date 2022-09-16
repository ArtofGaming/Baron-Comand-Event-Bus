using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientEventBus : MonoBehaviour
{
    private bool _isButtonEnabled;

    void Start()
    {
        gameObject.AddComponent<HUDControllerClass>();
        gameObject.AddComponent<CountdownTimer>();
        gameObject.AddComponent<BikeController>();
        _isButtonEnabled = true;
    }

    private void OnEnable()
    {
        RaceEventBus.Subscribe(RaceEventType.STOP, Restart);
    }

    private void Restart()
    {
        _isButtonEnabled = true;
    }

    private void OnGUI()
    {
        if (_isButtonEnabled)
        {
            if (GUILayout.Button("Start Countdown", GUILayout.Width(200)))
            {
                _isButtonEnabled = false;
                RaceEventBus.Publish(RaceEventType.COUNTDOWN);
            }
        }
    }

    private void OnDisable()
    {
        RaceEventBus.Unsubscribe(RaceEventType.STOP, Restart);
    }

    void Update()
    {
        
    }
}
