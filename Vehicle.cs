namespace noura
{
    abstract class Vehicle //base class
{
    public abstract int Id{  
       get;  
       set;  
    }  
    public abstract int Color{  
       get;  
       set;  
    }  
    public abstract int SerialNumber{  
       get;  
       set;  
    }  

    public abstract void MoveForward();
    public abstract void Turn(string Direction);
    public abstract void Stop();

}
}