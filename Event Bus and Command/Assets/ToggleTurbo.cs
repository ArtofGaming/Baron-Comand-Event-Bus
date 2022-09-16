using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTurbo : Command
{
    private BikeController _controller;

    public ToggleTurbo(BikeController controller)
    {
        _controller = controller;
    }

    public override void Execute()
    {
        _controller.ToggleTurbo();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
