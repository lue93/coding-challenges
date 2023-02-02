import java.util.Scanner;

public class Solution {


    static boolean isAnagram(String a, String b) {
        // Complete the function
        
        java.util.Map<Character, Integer> letrasD = new java.util.HashMap<>();
        java.util.Map<Character, Integer> letrasE = new java.util.HashMap<>();

        boolean is = false;

        a = a.toLowerCase();
        b = b.toLowerCase();
        int counter = 0;
        for(int i = 0; i < a.length(); i++) {
            char letra = a.charAt(i);
            if(letrasD.get(letra) == null) {
                letrasD.put(letra, 1);
            } else { 
                Integer n = letrasD.get(letra);
                letrasD.put(letra, n + 1);
            }
        }
        
        int counter2 = 0;
        for(int j = b.length(); j > 0; j--) {
            char letra = b.charAt(j-1);
            if(letrasE.get(letra) == null) {
                letrasE.put(letra, 1);
            } else { 
                Integer n = letrasE.get(letra);
                letrasE.put(letra, n + 1);
            }
        }
        is = letrasD.equals(letrasE);
        return is;
    }

  public static void main(String[] args) {
    
        Scanner scan = new Scanner(System.in);
        String a = scan.next();
        String b = scan.next();
        scan.close();
        boolean ret = isAnagram(a, b);
        System.out.println( (ret) ? "Anagrams" : "Not Anagrams" );
    }
}
