using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public DirectionState DirectionState => _directionState;

    public ColorState ColorState => _colorState;

    [SerializeField]
    private DirectionState _directionState = DirectionState.Horizon;

    [SerializeField]
    private ColorState _colorState = ColorState.Green;
}

