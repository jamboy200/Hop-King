

public partial class StateBase : Resource
{
    public enum State{
        ENTER,
        UPDATE,
        EXIT
    }
    public State state { get; set; }=State.ENTER;
    
    protected StateBase NextState;
    public StateMachine Parent { get; set; }

    public StateBase()
    {
        NextState=this;
        state=State.ENTER;
    }
    public StateBase Evalute(float delta)
    {
        if(state==State.ENTER)
        {
            Enter();
        }
        if(state==State.UPDATE)
        {
            Update(delta);
        }
        if(state==State.EXIT)
        {
            Exit();
        }
        return NextState;
    }

    protected virtual void Exit()
    {
       
       state=State.ENTER;
    }

    protected virtual void Update(float delta)
    {
        state=State.EXIT;
    }

    protected virtual void Enter()
    {
         NextState=this;
        state=State.UPDATE;

    }
    protected void SwtichTo(string name)
    {
        if(Parent.Get(name)!=null)
        {
            NextState=Parent.Get(name);
        }
    }
}