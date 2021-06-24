

namespace noura
{
   abstract class Car : Vehicle 
{
    public abstract int KeyId{  
       get;  
       set;  
    }  
    public abstract int NumOfPassengers{  
       get;  
       set;  
    }  
    public abstract int NumOfDoors{  
       get;  
       set;  
    }  
    public abstract string WheelsPower{  
       get;  
       set;  
    }  
    public abstract string Fuel{  
       get;  
       set;  
    }  
    public abstract void Switch();
    
 //   public abstract bool AirbagFacilition();
}
}