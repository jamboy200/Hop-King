public partial class Idel : StateBase
{
    protected override void Enter()
    {
        base.Enter();
    }
    protected override void Update(float delta)
    {
        GD.Print("idel");
        if(Input.IsActionPressed("jump"))
        {
            SwtichTo("prejump");
            state=State.EXIT;
        }
        else if((Input.IsActionPressed("left") || Input.IsActionPressed("right"))
        && Parent.GetTarget<CharacterBody2D>().IsOnFloor())
        {
            SwtichTo("walkground");
            state=State.EXIT;
        }
        var tar=Parent.GetTarget<Toad>();
        tar.res.Direction=tar.res.Direction.Lerp(0,tar.res.Friction);
        if(tar.IsOnFloor())
        {
            tar.Velocity=new Vector2(Math.Abs(tar.res.Direction)*tar.Velocity.X,tar.Velocity.Y);
        }

    }
}
