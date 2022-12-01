import java.lang.reflect.Array;
import java.util.*;

public class Demo {
    static char[] solution(String str) {
        List<Character> characterList = new ArrayList<>();
        for (int i = 0; i <str.length() ; i++) {
            for (int j = 1; j < str.length() ; j++) {
                if(str.charAt(i) == str.charAt(j) && i!=j){
                    if(!characterList.contains(str.charAt(j))){
                    characterList.add(str.charAt(j));}
                    break;
                }
            }
        }
        char[] chars = new char[characterList.size()];
        for (int i = 0; i <characterList.size() ; i++) {
            chars[i] = characterList.get(i);
        }
        return chars;
    }

    public static void main(String[] args) {
        System.out.println(Arrays.toString(solution("abcbcdef")));

    }
}
