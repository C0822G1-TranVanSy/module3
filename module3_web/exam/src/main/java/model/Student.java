package model;

public class Student {
    private int id;
    private String name;
    private boolean gender;
    private String dateOfBirth;
    private double score;
    private StudentClass studentClass;

    public Student() {
    }

    public Student(String name, boolean gender, String dateOfBirth, double score, StudentClass studentClass) {
        this.name = name;
        this.gender = gender;
        this.dateOfBirth = dateOfBirth;
        this.score = score;
        this.studentClass = studentClass;
    }

    public Student(int id, String name, boolean gender, String dateOfBirth, double score, StudentClass studentClass) {
        this.id = id;
        this.name = name;
        this.gender = gender;
        this.dateOfBirth = dateOfBirth;
        this.score = score;
        this.studentClass = studentClass;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public boolean isGender() {
        return gender;
    }

    public void setGender(boolean gender) {
        this.gender = gender;
    }

    public String getDateOfBirth() {
        return dateOfBirth;
    }

    public void setDateOfBirth(String dateOfBirth) {
        this.dateOfBirth = dateOfBirth;
    }

    public double getScore() {
        return score;
    }

    public void setScore(double score) {
        this.score = score;
    }

    public StudentClass getStudentClass() {
        return studentClass;
    }

    public void setStudentClass(StudentClass studentClass) {
        this.studentClass = studentClass;
    }
}
