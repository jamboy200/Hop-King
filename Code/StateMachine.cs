

public partial class StateMachine: Resource
{
    private Dictionary<string,StateBase>States;
    StateBase Default=null;
    Node2D Target;
    public StateMachine(Node2D tar)
    {
        Target=tar;
        States=new Dictionary<string, StateBase>();
    }
    public StateMachine AddSate(StateBase state,string Name)
    {
        if(!States.ContainsKey(Name))
        {
            States.Add(Name,state);
            state.Parent=this;
        }
        if(Default==null)
        {
            Default=state;
        }
        return this;
    }

    
    public void Update(float delta)
    {
        Default=Default.Evalute(delta);
    }
    
    public StateBase  Get(string Name)
    {
        if(States.ContainsKey(Name))
        {
            return States[Name];
        }
        return null;
    }
    public T GetTarget<T>() where T: Node2D
    {
        return (T)Target;
    }
}