class Student {
  private Integer studentId;
  private String studentName;
  private String collegeName;
  private String address;

  public Integer getStudentId(){
    return studentId;
  }

  public void setStudentId(Integer studentId){
    this.studentId = studentId;
  }

  public String getStudentName(){
    return studentName;
  }

  public void setStudentName(String studentName){
    this.studentName = studentName;
  }

  public String getCollegeName(){
    return collegeName;
  }

  public void setCollegeName(String collegeName){
    this.collegeName = collegeName;
  }

  public String getAddress(){
    return address;
  }

  public void setAddress(String address){
    this.address = address;
  }
}

class TestStudent {
  public static void main(String[] args){
    Student s = new Student();
    
    s.setAddress("232 S.Fenton St.");
    System.out.println(s.getAddress()); 

    s.setCollegeName("UCD");
    System.out.println(s.getCollegeName());

    s.setStudentId(123);
    System.out.println(s.getStudentId());

    s.setStudentName("John");
    System.out.println(s.getStudentName());

  }
}