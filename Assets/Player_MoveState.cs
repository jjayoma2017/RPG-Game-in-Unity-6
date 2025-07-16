using UnityEngine;

public class Player_MoveState : EntityState
{
    public Player_MoveState(Player player, StateMachine stateMachine, string stateName) : base(player, stateMachine, stateName)
    {
    }

    public override void Update()
    {
        base.Update();

        if (player.moveInput.x==0)
        {
            // Transition to idle state when no move key is pressed
            stateMachine.ChangeState(player.idleState);
        }
    }
}
