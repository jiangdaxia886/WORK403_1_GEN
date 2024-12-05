using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBaseState
{
    protected PlayerStates state;
    protected PlayerController ctx;

    protected PlayerBaseState(PlayerStates state, PlayerController context)
    {
        this.state = state;
        this.ctx = context;
    }

    public PlayerStates State { get => state; }

    //每一帧都执行的逻辑
    public abstract PlayerStates Update(float deltaTime);

    public abstract IEnumerator Coroutine();

    public abstract void OnBegin();

    public abstract void OnEnd();

    public abstract bool IsCoroutine();
}
