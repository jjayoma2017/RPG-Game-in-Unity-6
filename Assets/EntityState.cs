using Unity.VisualScripting;
using UnityEngine;

public abstract class EntityState 
{
    protected Player player;
    protected StateMachine stateMachine;
    protected string animBoolName;
    protected Animator anim;
    public EntityState(Player player, StateMachine stateMachine, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.animBoolName = animBoolName;
        anim = player.anim;
    }

    public virtual void Enter()
    {
        // Called everytime  the state is changed
        anim.SetBool(animBoolName, true);
    }

    public virtual void Update()
    {
        // We are going to run logic of the state here
        Debug.Log($"Updating state: {animBoolName}");
    }

    public virtual void Exit()
    {
        // Called everytime  the state is exited and changed to a new one
        anim.SetBool(animBoolName, false);
    }

    

}
