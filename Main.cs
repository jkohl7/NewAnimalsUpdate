public class Main {
    
    private static FileOutput outFile = new FileOutput("animals.txt");
    
    private static FileInput inFile = new FileInput("animals.txt");
    
    public static void main(String[] args) {
        ArrayList<Talkable> zoo = new ArrayList();
        zoo.add(new Dog(true, "Bean"));
        zoo.add(new Cat(9, "Charlie"));
        zoo.add(new Teacher(44, "Stacy Read"))
        foreach (Talkable thing in zoo) {
            Main.printOut(thing);
        }
        
        outFile.fileClose();
        inFile.fileRead();
        inFile.fileClose();
        FileInput indata = new FileInput("animals.txt");
        String line;
        while ((indata.fileReadLine() != null)) {
            System.out.println(line);
        }
        
    }
    
    public static void printOut(Talkable p) {
        System.out.println((p.getName() + (" says=" + p.talk())));
        outFile.fileWrite((p.getName() + (" | " + p.talk())));
    }
}