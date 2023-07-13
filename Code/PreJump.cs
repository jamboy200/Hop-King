public partial class PreJump :StateBase
{

    protected override void Enter()
    {
        var tar=Parent.GetTarget<Toad>();
        tar.res.JumpScale=0;
        tar.Velocity=new Vector2(0,tar.Velocity.Y);
        base.Enter();
    }
    protected override void Update(float delta)
    {
        var tar=Parent.GetTarget<Toad>();
        if(!tar.IsOnFloor())
        {
             
            SwtichTo("jumping");
           
            state=State.EXIT;
            return;
        }
        GD.Print("prejump");
         if(Input.IsActionPressed("left"))
        {
            tar.res.Direction=-1;
        }
        else if(Input.IsActionPressed("right"))
        {
            tar.res.Direction=1;
        }else
        {
            tar.res.Direction=0;
        }
        if(!Input.IsActionPressed("jump") || tar.res.IsMax())
        {
            
            SwtichTo("jump");
           
            state=State.EXIT;
        }
        tar.res.JumpScale+=delta;
        
    }
   
}
