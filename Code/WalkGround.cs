public partial class WalkGround :StateBase
{
    public float Speed { get; set; }
    public WalkGround(float Speed)
    {
        this.Speed=Speed;
    }
    protected override void Update(float delta)
    {
        GD.Print("walk");
        var tar=Parent.GetTarget<Toad>();
        if(Input.IsActionPressed("left"))
        {
            tar.res.Direction=-1;
            tar.Velocity=new Vector2(-Speed,tar.Velocity.Y);
        }
        if(Input.IsActionPressed("right"))
        {
            tar.res.Direction=-1;
            tar.Velocity=new Vector2(Speed,tar.Velocity.Y);
        }
        if(Input.IsActionPressed("jump"))
        {
            tar.Velocity=new Vector2(0,tar.Velocity.Y);
             state=State.EXIT;
            SwtichTo("prejump");   
        }
        if(!Input.IsActionPressed("left") && !Input.IsActionPressed("right"))
        {
            state=State.EXIT;
            SwtichTo("idel");    
        }
        
        
    }
}
