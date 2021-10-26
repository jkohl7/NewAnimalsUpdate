public class Dog : Pet, Talkable {
    
    private bool friendly;
    
    public Dog(bool friendly, String name) : 
        base(name) {
        base.(name);
        this.friendly = this.friendly;
    }
    
    public bool isFriendly() {
        return this.friendly;
    }
    
    [Override()]
    public String talk() {
        return "Bark";
    }
    
    [Override()]
    public String toString() {
        return ("Dog: " + ("name=" 
                           + (name + (" friendly=" + this.friendly))));
    }
}