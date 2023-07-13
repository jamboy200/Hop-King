

public partial class Jumping : StateBase
{
    protected override void Update(float delta)
    {
        GD.Print("jumping");
        var tar=Parent.GetTarget<Toad>();
        if(!tar.IsOnFloor() &&(
        tar.GetNode<RayCast2D>("right").IsColliding()))
        {
            tar.Velocity=new Vector2(-tar.res.HorizentalSpeedAir,
            tar.Velocity.Y);
            
        }
        if(!tar.IsOnFloor() &&(
        tar.GetNode<RayCast2D>("left").IsColliding()))
        {
            tar.Velocity=new Vector2(tar.res.HorizentalSpeedAir,
            tar.Velocity.Y);
            
        }
        if(tar.IsOnFloor())
        {
            state=State.EXIT;
            SwtichTo("idel");
            
        }
        
    }
}