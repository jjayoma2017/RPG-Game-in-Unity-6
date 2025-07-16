using UnityEngine;

public class Player_IdleState : EntityState
{
    public Player_IdleState(Player player,StateMachine stateMachine, string stateName) : base(player,stateMachine, stateName)
    {
    }

    public override void Update()
    {
        base.Update();
       
        if(player.moveInput.x!=0)
        {
            // Transition to move state when A/D is pressed
            stateMachine.ChangeState(player.moveState);
        }
    }

}
