using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class AbstractPlayerAction : ISlimeAction
{
    protected ISlimeAction slimeAction;

    public abstract void Move();
}
