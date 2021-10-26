public class Teacher : Person, Talkable {
    
    private int age;
    
    public Teacher(int age, String name) : 
        base(name) {
        base.(name);
        this.age = this.age;
    }
    
    public int getAge() {
        return this.age;
    }
    
    public void setAge(int age) {
        this.age = this.age;
    }
    
    [Override()]
    public String talk() {
        return "Don\'t forget to do the assigned reading!";
    }
}