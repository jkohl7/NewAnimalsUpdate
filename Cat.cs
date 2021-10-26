public class Cat : Pet, Talkable {
    
    private int mousesKilled;
    
    public Cat(int mousesKilled, String name) : 
        base(name) {
        base.(name);
        this.mousesKilled = this.mousesKilled;
    }
    
    public int getMousesKilled() {
        return this.mousesKilled;
    }
    
    public void addMouse() {
        this.mousesKilled++;
    }
    
    [Override()]
    public String talk() {
        return "Meow";
    }
    
    [Override()]
    public String toString() {
        return ("Cat: " + ("name=" 
                           + (name + (" mousesKilled=" + this.mousesKilled))));
    }
}