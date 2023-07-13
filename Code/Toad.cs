

public partial class Toad : CharacterBody2D
{
	[Export]
	public ToadRes res;
    StateMachine Machine;

	

    public override void _Ready()
    {
		
		Machine=new StateMachine(this);
		Machine.AddSate(new Idel(),"idel").
		AddSate(new WalkGround(res.HorizentalSpeed),"walkground").
		AddSate(new PreJump(),"prejump").
		AddSate(new Jump(),"jump").
		AddSate(new Jumping(),"jumping");
        base._Ready();
    }

    public override void _PhysicsProcess(double delta)
    {
		Machine.Update((float)delta);
		Velocity+=Vector2.Down*res.Gravity*(float)delta;
		MoveAndSlide();
        base._PhysicsProcess(delta);
    }
}
