using Unity.VisualScripting;
using UnityEngine;

public class EntityState 
{
    protected StateMachine stateMachine;
    protected string stateName;
    public EntityState(StateMachine stateMachine, string stateName)
    {
        this.stateMachine = stateMachine;
        this.stateName = stateName;
    }

    public virtual void Enter()
    {
        // Called everytime  the state is changed
        Debug.Log($"Entering state: {stateName}");
    }

    public virtual void Update()
    {
        // We are going to run logic of the state here
        Debug.Log($"Updating state: {stateName}");
    }

    public virtual void Exit()
    {
        // Called everytime  the state is exited and changed to a new one
        Debug.Log($"Exiting state: {stateName}");
    }

    

}
