package model;

public class StudentClass {
    private int id;
    private String className;

    public StudentClass() {
    }

    public StudentClass(int id) {
        this.id = id;
    }

    public StudentClass(int id, String className) {
        this.id = id;
        this.className = className;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getClassName() {
        return className;
    }

    public void setClassName(String className) {
        this.className = className;
    }
}
