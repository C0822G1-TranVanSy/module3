package common;

public class Regex {
    final String NAME_REGEX = "[A-Z][\\D]+";
    final String SCORE_REGEX = "^((\\d+(\\.\\d*)?)|(\\.\\d+))$";
    public boolean checkName(String name) {
        return name.matches(NAME_REGEX);
    }

    public boolean checkScore(String score) {
        return score.matches(SCORE_REGEX);
    }
}
