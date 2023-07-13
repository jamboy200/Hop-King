public partial class Jump :StateBase
{
    protected override void Update(float delta)
    {
        GD.Print("jump");
        var tar=Parent.GetTarget<Toad>();
       

        if(tar.IsOnFloor())
        {
         tar.Velocity=new Vector2(tar.res.Direction*tar.res.HorizentalSpeed,
         -tar.res.JumpForce*tar.res.JumpScale);
        }
         SwtichTo("jumping");
        base.Update(delta);
    }
    
}
