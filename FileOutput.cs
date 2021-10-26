public class FileOutput {
    
    private String fileName;
    
    public FileOutput(String fileName) {
        this.fileName = this.fileName;
        try {
            new BufferedWriter(new OutputStreamWriter(new FileOutputStream(this.fileName)));
        }
        catch (FileNotFoundException e) {
            System.out.println(("File Open Error: " 
                                + (this.fileName + (" " + e))));
        }
        
    }
    
    public void fileWrite(String line) {
        try {
            write((line + "\n"));
        }
        catch (Exception e) {
            System.out.println(("File Write Error: " 
                                + (this.fileName + (" " + e))));
        }
        
    }
    
    public void fileClose() {
        null;
        try {
            close();
        }
        catch (IOException e) {
            e.printStackTrace();
        }
        
    }
}