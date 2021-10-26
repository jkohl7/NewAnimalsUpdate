public class FileInput {
    
    private BufferedReader in = null;
    
    private String fileName;
    
    public FileInput(String fileName) {
        this.fileName = this.fileName;
        try {
            this.in = new BufferedReader(new FileReader(this.fileName));
        }
        catch (FileNotFoundException e) {
            System.out.println(("File Open Error: " 
                                + (this.fileName + (" " + e))));
        }
        
    }
    
    public void fileRead() {
        String line;
        try {
            while ((this.in.readLine() != null)) {
                System.out.println(line);
            }
            
        }
        catch (Exception e) {
            System.out.println(("File Write Error: " 
                                + (this.fileName + (" " + e))));
        }
        
    }
    
    public String fileReadLine() {
        try {
            String line = this.in.readLine();
            return line;
        }
        catch (Exception e) {
            System.out.println(("File Write Error: " 
                                + (this.fileName + (" " + e))));
            return null;
        }
        
    }
    
    public void fileClose() {
        if ((this.in != null)) {
            try {
                this.in.close();
            }
            catch (IOException e) {
                e.printStackTrace();
            }
            
        }
        
    }
}