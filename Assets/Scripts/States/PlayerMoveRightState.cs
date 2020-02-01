namespace States
{
    public class PlayerMoveRightState : PlayerBaseState
    {
        public override void EnterState(CharacterController2D player){
            player.SetAnimation("PlayerRight");
        }

        public override void Update(CharacterController2D player){
            if (player.Movement == 0)
            {
                player.TransitionToState(player.IdleState);
            }
        }

        public override void OnCollisionEnter(CharacterController2D player){
        
        }
    }
}